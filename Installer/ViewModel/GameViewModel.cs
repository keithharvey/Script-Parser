using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Installer.Helpers;
using Installer.Model;

namespace Installer.ViewModel

{
	[Serializable]
	public class GameViewModel : WorkspaceViewModel
	{
		#region Fields

		Game _game;
		string _abreviatedDisplayName;
	
		#endregion // Fields

        #region Properties

        public Game Game
        {
            get
            {
                return _game;
            }
        }

        #endregion Properties

        #region Constructors
        public GameViewModel(Game game)
		{
			_game = game;

			base.DisplayName = game.Name;
		}
		#endregion

		public string AbreviatedDisplayName
		{
			get
			{
				if (_abreviatedDisplayName == null)
					_abreviatedDisplayName = GetAbreviatedName(DisplayName);

				return _abreviatedDisplayName;
			}
		}

		#region Private Helpers

		/// <summary>
		/// Returns the first letter of every word in a given name.
		/// </summary>
		/// <param name="name">The name to be abreviated.</param>
		/// <returns>Returns the first letter of every word in a given name.</returns>
		static string GetAbreviatedName(string name)
		{
			return name;
		}

		#endregion // Private Helpers
	}
}
