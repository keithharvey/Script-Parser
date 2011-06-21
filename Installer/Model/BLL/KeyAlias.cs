using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
	public class KeyAlias : Alias
	{
		#region Fields
		private List<Alias> _subkeys = new List<Alias>();
		#endregion

		#region Properties
		public List<Alias> Subkeys
		{
			get { return _subkeys; }
		}
		public bool HasSubkeys
		{
			get { return _subkeys.Count > 0; }
		}
		#endregion

		#region Constructors
		public KeyAlias(string name)
			: base(name) {}
		public KeyAlias(string name, MetaData metaData) 
			: base(name, metaData) {}
		public KeyAlias(string name, List<object> targets, MetaData metaData) 
			: base(name, targets, metaData) {}
		#endregion

		#region Implementation
		public void CheckForSubkeys(List<Alias> possibleSubkeys)
		{
			foreach (object obj in Targets)
			{
				if (obj.GetType().Equals(typeof(Alias)))
				{
					Alias tempAlias = obj as Alias;
					if (tempAlias.MetaData.Type == MetaType.Subkey)
					{
						_subkeys.Add(tempAlias);
					}
				}
			}
		}
		#endregion
	}
}
