using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
    [Serializable]
    public class Exec : Statement
    {

        #region Property Getters and Setters

        public string Value { get; private set; }

        public bool RCON { get; private set; }

        #endregion

		#region Constructors

		public Exec(string value, StatementType statementType, MetaData<IMeta> metaData, bool rcon)
            : base(statementType, metaData)
		{
			Value = value;
            RCON = rcon;
		}
		#endregion
    }
}
