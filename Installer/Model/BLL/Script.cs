using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using Installer.Helpers;
using System.Linq;

namespace Installer.Model
{
    /// <summary>
    /// Contains an object representation of a source script, which it parses.
    /// </summary>
	[Serializable]
	public class Script
	{
		#region Fields

		// file data
		string _sourcePath;
		List<string> _files;
        List<IStatement> _content;

		#endregion // Fields

		#region Constructors

        /// <summary>
        /// Constructor for the script business logic.
        /// </summary>
        /// <param name="source">Root folder of the script to begin parsing.
        /// Ideally, or at least in many cases, this would accept a single
        /// file path and then read hierarchy from within that script.
        /// </param>
		public Script(string source)
		{
            Content = new List<IStatement>();
            Toggles = new List<Alias>();
            
			_sourcePath = source;
			if (Files.Count > 0)
			{
				ParseSourceScriptData(this);
			}
		}

		#endregion // Constructors

		#region Properties

        /// <summary>
        /// List of IMeta types supported by the script
        /// </summary>
        public Dictionary<string, IMeta> SupportedMetaData
        {
            get
            {
                SourceMetaToggle sourceMetaToggle = new SourceMetaToggle();
                return new Dictionary<string, IMeta>()
                {
                    { sourceMetaToggle.Identifier, sourceMetaToggle }
                };
            }
        }

        public List<IStatement> Content
        {
            get
            {
                if(_content == null)
                    _content = new List<IStatement>();

                return _content;
            }
            set
            {
                _content = value;
            }
        }

        public List<Alias> Toggles
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the script
        /// </summary>
        public string Name { get; set; }

		public List<string> Files
		{
			get
			{
				if (_files == null)
				{
					FileHandler file = new FileHandler();
					_files = file.GetFilesRec(_sourcePath);
				}

				return _files;
			}
		}
                		
		#endregion // Properties

		static void ParseSourceScriptData(Script script)
		{
			Translator translator = new Translator(script);
			// fills the script with parsed data
			translator.Parse();
			// populates the script with data that requires 
			// all raw data to be compiled beforehand
		}

		/*
		public void Apply(string destination)
		{
			FileHandler file = new FileHandler();
			Dictionary<string, string> emitMe = new Emitter(this).Rewrite();
			file.CreateFolderStructure(this._sourcePath, destination);
			foreach (KeyValuePair<string, string> emit in emitMe)
			{
				// get the relative path to the current script file
				// by pruning the sourcePath of this Script from it
				string fileName = emit.Key.Substring(this._sourcePath.Length + 1);
				// combine this relative path with our destination
				string destinationFile = Path.Combine(destination, fileName);
				// write that good ol' stuff!
				file.WriteToFile(destinationFile, emit.Value);
			}
		}
		private static List<string> CheckIfToggleAliasListModified(ref ObservableCollection<ToggleAlias> toggleAliases, List<string> filesToParse)
		{
			List<string> changes = new List<string>();
			Translator translator = new Translator(filesToParse);
			MetaDataList metaDataList = translator.RetrieveMetaData();
			Script parserScriptData = translator.RetrieveScriptData(metaDataList);
			ObservableCollection<ToggleAlias> ResultantToggleAliases = new ObservableCollection<ToggleAlias>();
			int aliasesMatched = 0;
			foreach (ToggleAlias parserToggleAlias in parserScriptData.ToggleAliases)
			{
				bool aliasExists = false;
				foreach (ToggleAlias loadedToggleAlias in toggleAliases)
				{
					if (parserToggleAlias.Equals((Data)loadedToggleAlias))
					{
						ResultantToggleAliases.Add(new ToggleAlias(parserToggleAlias.Name, parserToggleAlias.MetaData));
						aliasesMatched++;
						aliasExists = true;
						int childrenMatched = 0;
						foreach (KeyValuePair<Alias, string> parserChild in parserToggleAlias.Children)
						{
							int indexToUpdate;
							bool childExists = false;
							foreach (KeyValuePair<Alias, string> loadedChild in loadedToggleAlias.Children)
							{
								if (parserChild.Key.Equals((Data)loadedChild.Key))
								{
									childrenMatched++;
									childExists = true;
									indexToUpdate = ResultantToggleAliases.IndexOf(parserToggleAlias);
									ResultantToggleAliases[indexToUpdate].Children.Add(loadedChild.Key, loadedChild.Value);
									if (loadedChild.Key.Equals((Data)loadedToggleAlias.CurrentCommand))
									{
										ResultantToggleAliases[indexToUpdate].CurrentCommand = loadedToggleAlias.CurrentCommand;
									}
								}
							}
							if (!childExists)
							{
								indexToUpdate = ResultantToggleAliases.IndexOf(parserToggleAlias);
								ResultantToggleAliases[indexToUpdate].Children.Add(parserChild.Key, parserChild.Value);
								changes.Add("Child(submenu item) " + parserChild.Key.Name + " added to interface under toggle " + loadedToggleAlias.Name + " since the previous save.");
							}
						}
					}
				}
				if (!aliasExists)
				{
					ResultantToggleAliases.Add(parserToggleAlias);
					changes.Add("Menu option " + parserToggleAlias + " added to interface since the previous save.");
				}
			}
			toggleAliases = ResultantToggleAliases;
			return changes;
		}

		public List<string> Update()
		{
			List<string> updateChanges = new List<string>();
			FileHandler file = new FileHandler();
			if (!Directory.Exists(this._sourcePath))
			{
				throw new Exception("Cannot find source folder for the selected script. Unable to load script's section of the SCU since it cannot be installed without the source material present.");
			}
			return CheckIfToggleAliasListModified(ref _toggleAliases, _filesToParse);
		}*/



    }
}
