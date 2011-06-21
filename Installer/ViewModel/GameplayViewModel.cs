using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Installer.Helpers;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Data;


namespace Installer.Model
{
	[Serializable]
	public class GameplayViewModel : Data
	{
		#region Fields
		private string _sourcePath;
		private List<string> _filesToParse;
		private ObservableCollection<ToggleAlias> _toggleAliases = new ObservableCollection<ToggleAlias>();
		private ObservableCollection<KeyAlias> _keyAliases = new ObservableCollection<KeyAlias>();
		private MetaData _metaData;
		private List<Alias> _subkeys = new List<Alias>();
		private List<string> _subkeyPaths = new List<string>();
		private DataTable _weaponSettings = new DataTable();
		#endregion

		#region Properties
		public ObservableCollection<ToggleAlias> ToggleAliases
		{
			get { return _toggleAliases; }
			set { _toggleAliases = value; }
		}
		public ObservableCollection<KeyAlias> KeyAliases
		{
			get { return _keyAliases; }
			set { _keyAliases = value; }
		}
		public MetaData MetaData
		{
			get { return _metaData; }
			set 
			{ 
				_metaData = value;
				if (MetaData.Name != null)
				{
					Name = MetaData.Name;
				}
			}
		}
		public List<Alias> Subkeys
		{
			get { return _subkeys; }
			set { _subkeys = value; }
		}
		public List<string> SubkeyPaths
		{
			get { return _subkeyPaths; }
			set { _subkeyPaths = value; }
		}
		#endregion

		#region Constructors
		public GameplayViewModel(string name)
			: base(name){ }
		public GameplayViewModel(string name, string source)
			: base(name)
		{
			FileHandler file = new FileHandler();
			Name = file.GetFileName(source);
			_sourcePath = source;
			_filesToParse = file.GetFilesRec(_sourcePath);
			// parse in script data
			if (_filesToParse.Count > 0)
			{
				ScriptData parsedScriptData = ParseSourceScriptData(_filesToParse);
				// updates the current ScriptData with the container ScriptData passed from the parser
				CopyScriptData(parsedScriptData);
			}
		}
		#endregion

		#region Implementation
		/// <summary>
		/// Copies needed data from one ScriptData to another.
		/// </summary>
		/// <param name="SourceScriptData">ScriptData used to copy to current object's parameters</param>
		private void CopyScriptData(ScriptData SourceScriptData)
		{
			ToggleAliases = SourceScriptData.ToggleAliases;
			KeyAliases = SourceScriptData.KeyAliases;
			Subkeys = SourceScriptData.Subkeys;
			OnPropertyChanged("ToggleAliases");
			MetaData = SourceScriptData.MetaData;
			OnPropertyChanged("MetaData");
		}
		private ScriptData ParseSourceScriptData(List<string> filesToParse)
		{
			Translator translator = new Translator(filesToParse);
			MetaDataList metaDataList = translator.RetrieveMetaData();
			ScriptData returnData = translator.RetrieveScriptData(metaDataList);
			return returnData;
		}
		public void Apply(string destination)
		{
			FileHandler file = new FileHandler();
			Emitter emitter = new Emitter(_filesToParse, this);
			// get the modified files from the emitter
			Dictionary<string, string> emitMe = emitter.Rewrite();
			// output them to the appropriate location
			file.CreateFolderStructure(_sourcePath, destination);
			foreach (var emit in emitMe)
			{
				/* loads filename with just the trailing part of the path 
				 * e.g. competitive/binds.cfg */
				string fileName = emit.Key.Substring(_sourcePath.Length + 1);
				string destinationFile = Path.Combine(destination, fileName);
				file.WriteToFile(destinationFile, emit.Value);
			}
		}
		public List<string> Update()
		{
			List<string> updateChanges = new List<string>();
			// check to make sure source path still exists
			FileHandler file = new FileHandler();
			if (!Directory.Exists(_sourcePath))
			{
				throw new Exception("Cannot find source folder for the selected script. Unable to load script's section of the SCU since it cannot be installed without the source material present.");
			}

			// Now, we update the ToggleAliases property if it changed in the parser
			updateChanges = CheckIfToggleAliasListModified(ref _toggleAliases, _filesToParse);
			return updateChanges;
		}

		#region Static Helpers
		/// <summary>
		/// Checks parser data against toggle list and returns the modified list if changed.
		/// </summary>
		/// <param name="toggleAliases">list to check</param>
		/// <returns>true if data changed</returns>
		static List<string> CheckIfToggleAliasListModified(ref ObservableCollection<ToggleAlias> toggleAliases, List<string> filesToParse)
		{
			List<string> changes = new List<string>();
			Translator translator = new Translator(filesToParse);
			MetaDataList metaDataList = translator.RetrieveMetaData();
			ScriptData parserScriptData = translator.RetrieveScriptData(metaDataList);
			ObservableCollection<ToggleAlias> ResultantToggleAliases = new ObservableCollection<ToggleAlias>();
			int aliasesMatched = 0;
			foreach (ToggleAlias parserToggleAlias in parserScriptData.ToggleAliases)
			{
				bool aliasExists = false;
				foreach (ToggleAlias loadedToggleAlias in toggleAliases)
				{
					if (parserToggleAlias.Equals(loadedToggleAlias))
					{
						ResultantToggleAliases.Add(new ToggleAlias(parserToggleAlias.Name, parserToggleAlias.MetaData));
						aliasesMatched++;
						aliasExists = true;
						// check matched alias's children
						int childrenMatched = 0;
						foreach (var parserChild in parserToggleAlias.Children)
						{
							bool childExists = false;
							foreach (var loadedChild in loadedToggleAlias.Children)
							{
								if (parserChild.Key.Equals(loadedChild.Key))
								{
									childrenMatched++;
									childExists = true;
									int indexToUpdate = ResultantToggleAliases.IndexOf(parserToggleAlias);
									ResultantToggleAliases[indexToUpdate].Children.Add(loadedChild.Key, loadedChild.Value);
									// set the default if it still exists
									if (loadedChild.Key.Equals(loadedToggleAlias.CurrentCommand))
									{
										ResultantToggleAliases[indexToUpdate].CurrentCommand = loadedToggleAlias.CurrentCommand;
									}
								}
							}
							if (!childExists)
							{
								int indexToUpdate = ResultantToggleAliases.IndexOf(parserToggleAlias);
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
		#endregion
		#endregion
	}
}
