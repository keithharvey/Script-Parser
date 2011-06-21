using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Installer.Model
{
	[Serializable]
	public class Command : Statement, INotifyPropertyChanged
	{
		#region Fields
		

		#endregion

        #region Property Getters and Setters

        public string Identifier { get; protected set; }
        
        public string Value { get; private set; }

        public bool RCON { get; private set; }

		#endregion

		#region Constructors

		public Command(string identifier, string value, StatementType statementType, MetaData<IMeta> metaData, bool rcon)
            : base(statementType, metaData)
		{
            Identifier = identifier;
			Value = value;
            RCON = rcon;
		}
		#endregion

		#region Implementation

		public virtual void Display()
		{
			Debug.WriteLine(Identifier + " " + Value);
		}
		#endregion
    }
}
