using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Installer.Helpers;

namespace Installer.Model
{
	[Serializable]
	public class ToggleAlias : Alias
	{
		#region Fields
		// stores the alias children as well as their menu-friendly suffix (e.g. on, off)
		private Dictionary<Alias, string> _children = new Dictionary<Alias, string>();
		// state of the Index, points to current child as a command
		private int _currentDefaultIndex = 0;
		private Command _currentDefaultCommand;
		private int _numberOfDefaultChanges = 0;
		private int _numberOfDefaultChecks = 1;
		#endregion

		#region Properties
		public int NumberOfDefaultChanges
		{
			get { return _numberOfDefaultChanges; }
			set { _numberOfDefaultChanges = value; }
		}
		public bool CheckIfDefaultReached
		{
			get
			{
				if (NumberOfDefaultChecks == NumberOfDefaultChanges)
				{
					return true;
				}
				else
				{
					NumberOfDefaultChecks++;
					return false;
				}
			}
		}
		public int NumberOfDefaultChecks
		{
			get { return _numberOfDefaultChecks; }
			set { _numberOfDefaultChecks = value; }
		}
		public Dictionary<Alias, string> Children
		{
			get { return _children; }
		}
		public int CurrentCommandIndex
		{
			get { return _currentDefaultIndex; }
			set
			{
				_currentDefaultIndex = value;
				OnPropertyChanged("CurrentDefaultIndex");
				int x = 0;
				foreach (Alias child in Children.Keys)
				{
					if (x == value)
						if (!CurrentCommand.ToString().Equals(child.Name))
						{
							CurrentCommand = new Command(child.Name);
						}
					x++;
				}
			}
		}
		public Command CurrentCommand
		{
			get { return _currentDefaultCommand; }
			set
			{
				_currentDefaultCommand = value;
				OnPropertyChanged("CurrentCommand");
				int x = 0;
				foreach (Alias child in Children.Keys)
				{
					if (child.ToString() == value.ToString())
						CurrentCommandIndex = x;
					x++;
				}
			}
		}
		public bool HasChildren
		{
			get
			{
				if (_children.Count > 0)
					return true;
				else
					return false;
			}
		}
		#endregion

		#region Constructors
		public ToggleAlias(string name)
			: base(name) {}
		public ToggleAlias(string name, MetaData metaData) 
			: base(name, metaData) {}
		public ToggleAlias(string name, List<object> targets, MetaData metaData) 
			: base(name, targets, metaData) {}
		#endregion

		#region Implementation
		public void ResetNumberOfDefaultChecks()
		{
			NumberOfDefaultChecks = 1;
		}
		public void FillWithParserData(List<Alias> aliasList, List<Command> commandList)
		{
			_children = FindChildren(this, aliasList);
			// checks the list of commands in order to find a default menu option
			CurrentCommand = FindDefaultState(this, commandList, _children);
		}
		public bool CheckThisForStateCommand(Command command)
		{
			return IsAStateCommand(this, command);
		}
		#endregion

		#region Static Helpers
		static Dictionary<Alias, string> FindChildren(Alias currentAlias, List<Alias> list)
		{
			Dictionary<Alias, string> result = new Dictionary<Alias, string>();
			foreach (Alias alias in list)
			{
				if (alias.Name.BeginsWithAndIsnt(currentAlias.Name))
				{
					if (alias.MetaData.HasAltName)
					{
						result.Add(alias, alias.MetaData.AltName);
					}
					else
					{
						result.Add(alias, currentAlias.ToOption(alias));
					}
				}
			}
			return result;
		}
		/// <summary>
		/// Checks a list of commands in order to find the last command call for a given alias.
		/// </summary>
		/// <param name="toggleAlias">alias to check</param>
		/// <param name="commandList">list of commands to search</param>
		/// <param name="children">children of alias in question in case commands do not contain any calls</param>
		/// <returns></returns>
		static Command FindDefaultState(ToggleAlias toggleAlias, List<Command> commandList, Dictionary<Alias, string> children)
		{
			Command result = null;
			foreach (Command command in commandList)
			{
				if (IsAStateCommand(toggleAlias, command))
				{
					toggleAlias.NumberOfDefaultChanges++;
					result = command;
				}
			}
			if (result == null)
				result = new Command(children.Keys.First().Name);

			return result;
		}
		/// <summary>
		/// returns true if alias contains a child matching the given command
		/// </summary>
		/// <param name="alias">alias to cross-check children</param>
		/// <param name="command">command to match</param>
		/// <returns>true if command matches a child</returns>
		private static bool IsAStateCommand(ToggleAlias toggleAlias, Command command)
		{
			bool result = false;
			// check to see if the command starts with the same prefix
			// saves processing time iterating unnecessarilly
			if (command.Name.BeginsWith(toggleAlias.Name))
			{
				// iterate through the children to see if there's an alias match defined
				foreach (Alias child in toggleAlias.Children.Keys)
				{
					if (child.ToString().Equals(command.ToString()))
					{
						result = true;
					}
				}
			}
			return result;
		}
		#endregion
	}
}