using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Installer.Helpers;

namespace Installer.ViewModel
{
	[Serializable]
	public class ViewData : ViewModelBase
	{
		private int _currentGameIndex;
		private ObservableCollection<GameViewModel> _games = new ObservableCollection<GameViewModel>();
		private DataTable _weaponSettings = new DataTable();

		#region Properties
		#endregion

		#region Constructors
		public ViewData(string name) 
			: base(name)
		{
			FileHandler file = new FileHandler();
			foreach (string s in file.GetDirectorySubfolders(file.Files))
			{
				GameViewModel game = new GameViewModel(Path.GetFileName(s), s);
				Games.Add(game);
			}
		}
		#endregion

		#region Implementation

		public void Apply()
		{
			CurrentGame.Apply();
		}
		public Dictionary<string, List<string>> Update()
		{
			Dictionary<string, List<string>> updateChanges = new Dictionary<string, List<string>>();
			foreach (GameData gameData in Games)
			{
				var gameUpdateChanges = gameData.Update();
				updateChanges.AddRange(gameUpdateChanges.Select
					(e => new KeyValuePair<string, List<string>>(e.Key, e.Value)) );
			}
			return updateChanges;
		}

		public void PopulateWeaponSettings()
		{
			_weaponSettings.Columns.Add(new DataColumn("Weapon", typeof(string)));
			foreach (Alias subkey in CurrentGame.CurrentScript.Subkeys)
			{
				_weaponSettings.Columns.Add(new DataColumn(subkey.Name, typeof(bool)));
			}

			foreach (var key in CurrentGame.CurrentScript.KeyAliases)
			{
				if (key.HasSubkeys)
				{
					var row = _weaponSettings.NewRow();
					_weaponSettings.Rows.Add(row);
					row["Weapon"] = key.Name;
					foreach (var subkey in key.Subkeys)
					{
						row[subkey.Name] = true;
					}
				}
			}
		}
		#endregion
	}
}
