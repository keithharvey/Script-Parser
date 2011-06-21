using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Input;
using Installer.Model;
using Installer.Properties;
using Installer.Helpers;

namespace Installer.ViewModel
{
    /// <summary>
    /// For an un-named configuration for an unknown game. Interface is in limbo.
    /// </summary>
	class NewConfigurationViewModel : WorkspaceViewModel, IDataErrorInfo
	{
		#region Fields

		List<GameViewModel> _games;
		string _configurationName;
		int _selectedGameIndex = 0;

		#endregion // Fields

		#region Constructors

		public NewConfigurationViewModel()
		{
			base.DisplayName = Strings.NewConfigurationViewModel_DisplayName;
		}

		#endregion // Constructors

		#region UI Properties

		public int SelectedGameIndex
		{
			get { return _selectedGameIndex; }
			set { _selectedGameIndex = value; }
		}

		/// <summary>
		/// Configuration name that appears in the text box, user editable
		/// </summary>
		public string ConfigurationName
		{
			get
			{
				if (_configurationName == null)
				{
					_configurationName = "My Configuration";
				}

				return _configurationName;
			}
			set 
			{ 
				_configurationName = value;
				OnPropertyChanged("ConfigurationName");
			}
		}

		public List<GameViewModel> Games
		{
			get
			{
				if (_games == null)
				{
					_games = new List<GameViewModel>();
					
					FileHandler file = new FileHandler();
					foreach (string s in file.GetDirectorySubfolders(file.Files))
					{
						Game game = new Game(s);
						_games.Add( new GameViewModel(game) );
					}
				}

				return _games;
			}
		}

		#endregion // UI Properties
		
		#region IDataErrorInfo Members

		string IDataErrorInfo.Error { get { return null; } }

		string IDataErrorInfo.this[string propertyName]
		{
			get
			{
				string error = null;

				if (propertyName == "ConfigurationName")
				{
					// The IsCompany property of the Customer class 
					// is Boolean, so it has no concept of being in
					// an "unselected" state.  The CustomerViewModel
					// class handles this mapping and validation.
					error = this.ValidateConfigurationName();
				}

				// Dirty the commands registered with CommandManager,
				// such as our Save command, so that they are queried
				// to see if they can execute now.
				CommandManager.InvalidateRequerySuggested();

				return error;
			}
		}

		string ValidateConfigurationName()
		{
			if (IsFilenameValid(ConfigurationName))
				return null;

			return Strings.NewConfigurationViewModel_Error_FileInvalid;
		}
		/// <summary>
		/// Check if filename is valid on Win32 platforms (does not contain invalid characters)
		/// </summary>
		/// <param name="inputFileName">Name of the input file.</param>
		/// <returns>
		///     <c>true</c> if input filename is valid otherwise, <c>false</c>.
		/// </returns>
		/// 
		bool IsFilenameValid(string inputFileName)
		{
			Match m = Regex.Match(inputFileName, @"[\\\/\:\*\?\" + Convert.ToChar(34) + @"\<\>\|]");
			return !(m.Success);
		}

		#endregion // IDataErrorInfo Members

		#region Private Helpers

		public override bool CanOk() 
		{ 
			return IsFilenameValid(ConfigurationName); 
		}

		#endregion // Private Helpers
	}
}
