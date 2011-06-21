using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Installer.Model;

namespace Installer.Model
{


    public class Statement : IStatement, INotifyPropertyChanged
    {

        public StatementType StatementType { get; protected set; }
        public MetaData<IMeta> MetaData { get; protected set; }

        #region Constructors
        
        public Statement(StatementType statementType, MetaData<IMeta> metaData)
        {
            StatementType = statementType;
            MetaData = metaData;
        }

        #endregion

        #region Implementation of INotifyPropertyChanged

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
