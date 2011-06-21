using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
    [Serializable]
    public class Bind : Statement
    {

        #region Property Getters and Setters

        public string Key { get; private set; }
        
        public List<IStatement> Value { get; private set; }

        #endregion

        #region Constructors

        public Bind(string key, List<IStatement> value, StatementType statementType, MetaData<IMeta> metaData)
            : base(statementType, metaData)
        {
            Key = key;
            Value = value;
        }

        #endregion
    }
}
