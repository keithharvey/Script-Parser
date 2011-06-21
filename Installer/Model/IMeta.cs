using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
    public interface IMeta
    {
        string Identifier { get; }
        int NumberOfMetaFields { get; }
        bool IsAValidField(int index, string field, bool first);
        bool IsAValidField(int index, int field, bool first);
        bool FieldIsInt(int index);
        void AddMetaField(int index, int field);
        void AddMetaField(int index, string field);
    }
}
