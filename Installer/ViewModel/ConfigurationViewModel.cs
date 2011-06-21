using System;
using System.Linq;
using Installer.Model;

namespace Installer.ViewModel
{
	public class ConfigurationViewModel : WorkspaceViewModel
	{
		Configuration _configuration;

		public override string DisplayName
		{
			get
			{
				if (base.DisplayName == null)
					base.DisplayName = _configuration.Name + "(" + AbbreviateString(Configuration.Game.Name) + ")";

				return base.DisplayName;
			}
			protected set
			{
				base.DisplayName = value;
			}
		}

		#region Constructors

		public ConfigurationViewModel(Configuration configuration)
		{
			_configuration = configuration;
		}

		#endregion // Constructors

		#region Configuration Property

		public Configuration Configuration
		{
			get { return _configuration; }
		}

		#endregion // Configuration Property

		#region Private Helpers

		string AbbreviateString(string fullString)
		{
			string abString = null;
			string[] splitString = fullString.Split(new string[]{" ",}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string s in splitString)
			{
				abString += s.Substring(0,1).ToUpper();
			}
			return abString;
		}

		#endregion // Private Helpers
	}
}