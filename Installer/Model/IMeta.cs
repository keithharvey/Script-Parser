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
        /// <summary>
        /// Adds a meta field to the appropriate index of our meta type.
        ///     Throws an exception if field type is not supported.
        /// </summary>
        /// <param name="index">index to be added</param>
        /// <param name="field">integer to be added</param>
        void AddMetaField(int index, int field);
        /// <summary>
        /// Adds a meta field to the appropriate index of our meta type.
        ///     Throws an exception if field type is not supported.
        /// </summary>
        /// <param name="index">index to be added</param>
        /// <param name="field">content of field</param>
        void AddMetaField(int index, string field);
        /// <summary>
        /// Tells the parser whether or not this meta type should be associated with a statement.
        /// </summary>
        bool IsIndependent { get; }
    }
}
