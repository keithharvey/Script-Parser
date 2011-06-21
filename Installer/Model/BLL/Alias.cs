using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Installer.Model
{
	[Serializable]
	public class Alias : Statement, INotifyPropertyChanged
	{
		#region Fields
		
		#endregion

        #region Property Getters and Setters

        public string Identifier { get; protected set; }
        
        public List<IStatement> Value { get; private set; }

		#endregion

		#region Constructors
        /// <summary>
        /// Stores an Alias source script statement
        /// </summary>
        /// <param name="identifier">name of the alias from the script, so alias identifier value</param>
        /// <param name="value">name of the alias from the script, so alias identifier "value?; value?; value?"</param>
        /// <param name="statementType">type of source statement: exec, bind, alias, command</param>
        /// <param name="metaData"></param>
        public Alias(string identifier, List<IStatement> value, StatementType statementType, MetaData<IMeta> metaData)
            : base(statementType, metaData)
		{
            Identifier = identifier;
			Value = value;
            StatementType = statementType;
            MetaData = metaData;
		}

		#endregion

		#region ToOption Legacy bs
		public string ToOption(Alias optionAlias)
		{
			string result = optionAlias.ToString().Substring(this.ToString().Length);
			if (result.IndexOf("_") == 0)
			{
				result = result.Substring(1);
			}
			return result;
		}
		#endregion
	}
}
