using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
    public enum StatementType
    {
        Alias,
        Command,
        Bind,
        Exec
    }

    public interface IStatement
    {
        StatementType StatementType { get; }
        MetaData<IMeta> MetaData{get; }
    }
}
