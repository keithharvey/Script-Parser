using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Nini.Config;
using Installer.Helpers;
using Installer.Properties;

namespace Installer.Model
{
	public class Game : IDataErrorInfo
	{
		#region Fields
		
		string _name;
		// source paths
		string _sourcePathRoot;
		string _sourcePathScripts;
		string _sourcePathFps;
		string _sourcePathHuds;
		// destination paths
		string _destinationPathRoot;
		string _destinationPathScripts;
		string _destinationPathFps;
		string _destinationPathHuds;
		// game data
        // should be an interface
		List<Script> _scripts;
		
		#endregion // Fields

		#region Constructor

		public Game(string path)
		{
			if (path == null)
				throw new NullReferenceException();

			// the root of our source files for this game
			// this is not modifiable by users so is read-only
			_sourcePathRoot = path;

            foreach (var script in Scripts)
            {
                Debug.WriteLine(script.Name);
            }
		}

		#endregion // Constructor

		public string Name
		{
			get 
			{
				if (_name == null)
				{    
					IConfigSource source = new IniConfigSource(Path.Combine(_sourcePathRoot, "GameInfo.ini"));

					string configGameName = source.Configs["Game Info"].Get("Game Name");
					if (configGameName != null)
						_name = source.Configs["Game Info"].Get("Game Name");
					else
						_name = new FileInfo(@_sourcePathRoot + "\\").Directory.Name;
				}
				return _name; 
			}
		}

		#region Source Path Properties

		public string SourcePathRoot
		{
			get { return _sourcePathRoot; }
		}

		public string SourcePathScripts
		{
			get
			{
				if (_sourcePathScripts == null)
					_sourcePathScripts = Path.Combine(_sourcePathRoot, "scripts");

				return _sourcePathScripts;
			}
		}

		public string SourcePathFps
		{
			get
			{
				if (_sourcePathFps == null)
					_sourcePathFps = Path.Combine(_sourcePathRoot, "FPSConfigs");

				return _sourcePathFps;
			}
		}

		public string SourcePathHuds
		{
			get
			{
				if (_sourcePathHuds == null)
					_sourcePathHuds = Path.Combine(_sourcePathRoot, "HUDs");

				return _sourcePathHuds;
			}
		}

		#endregion // Source Path Properties

		#region Destination Path Properties

		/// <summary>
		/// The root destination path for this game, this is modifiable by users
		/// in order to ensure users with multiple steam accounts can properly
		/// point to the desired installation.
		/// </summary>
		public string DestinationPathRoot
		{
			get
			{
				if (_destinationPathRoot == null)
				{
					// load our config file
					IConfigSource source = new IniConfigSource(Path.Combine(_sourcePathRoot, "GameInfo.ini"));
					// registry key/subkey pair needed to pull a value from the registry for this game
					// this is stored in the GameInfo cfg file for easy editability
					string regKey = source.Configs["Registry Info"].Get("Registry Key");
					string subKey = source.Configs["Registry Info"].Get("SubKey");

					FileHandler file = new FileHandler();

					string installPath = file.ReadKey(regKey, subKey);
					string installSubDir = source.Configs["Install Directories"].Get("Installation Subdirectory");

					_destinationPathRoot = Path.Combine(installPath, installSubDir);
				}

				return _destinationPathRoot; 
			}
			set { _destinationPathRoot = value; } // Needs validation!!!!!!
		}

		public string DestinationPathScripts
		{
			get
			{
				if (_destinationPathScripts == null)
				{
					// load our config file
					IConfigSource source = new IniConfigSource(Path.Combine(_sourcePathRoot, "GameInfo.ini"));
					string scriptSubDir = source.Configs["Install Directories"].Get("Script Directory");

					_destinationPathScripts = Path.Combine(DestinationPathRoot, scriptSubDir);
				}

				return _destinationPathScripts;
			}
		}

		public string DestinationPathFps
		{
			get
			{
				if (_destinationPathFps == null)
				{
					// load our config file
					IConfigSource source = new IniConfigSource(Path.Combine(_sourcePathRoot, "GameInfo.ini"));
					string scriptSubDir = source.Configs["Install Directories"].Get("Script Directory");

					_destinationPathFps = Path.Combine(DestinationPathRoot, scriptSubDir);
				}

				return _destinationPathFps;
			}
		}

		public string DestinationPathHuds
		{
			get
			{
				if (_destinationPathHuds == null)
				{
					_destinationPathHuds = DestinationPathRoot;
				}

				return _destinationPathHuds;
			}
		}

		#endregion // Destination Path Properties

		#region Data Properties
		
		public List<Script> Scripts
		{
			get
			{
				if (_scripts == null)
				{
					FileHandler file = new FileHandler();
					foreach (string s in file.GetDirectorySubfolders(_sourcePathScripts))
					{
						Script script = new Script(Path.GetFileName(s));
						_scripts.Add(script);
					}
				}

				return _scripts;
			}
		}

		#endregion // Data Properties

		#region IDataErrorInfo Members

		string IDataErrorInfo.Error { get { return null; } }

		string IDataErrorInfo.this[string propertyName]
		{
			get { return this.GetValidationError(propertyName); }
		}

		#endregion // IDataErrorInfo Members

		#region Validation

		/// <summary>
		/// Returns true if this object has no validation errors.
		/// </summary>
		public bool IsValid
		{
			get
			{
				foreach (string property in ValidatedProperties)
					if (GetValidationError(property) != null)
						return false;

				return true;
			}
		}

		static readonly string[] ValidatedProperties = 
        { 
            "DestinationPath", 
            "SourcePath",
        };

		string GetValidationError(string propertyName)
		{
			if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
				return null;

			string error = null;

			switch (propertyName)
			{
				case "DestinationPath":
					error = this.ValidateDestinationPath();
					break;

				case "SourcePath":
					error = this.ValidateSourcePath();
					break;

				default:
					Debug.Fail("Unexpected property being validated on Customer: " + propertyName);
					break;
			}

			return error;
		}

		string ValidateSourcePath()
		{
			if (IsStringMissing(this.SourcePathRoot))
			{
				return Strings.Error_MissingPath;
			}
			if (!Directory.Exists(this.SourcePathRoot))
			{
				return Strings.Error_DirectoryDoesNotExist;
			}
			return null;
		}

		string ValidateDestinationPath()
		{
			if (IsStringMissing(this.DestinationPathRoot))
			{
				return Strings.Error_MissingPath;
			}
			if (!Directory.Exists(this.DestinationPathRoot))
			{
				return Strings.Error_DirectoryDoesNotExist;
			}
			return null;
		}

		static bool IsStringMissing(string value)
		{
			return
				String.IsNullOrEmpty(value) ||
				value.Trim() == String.Empty;
		}

		#endregion // Validation
	}
}