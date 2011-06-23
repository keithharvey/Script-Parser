using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
    public class SourceMeta : IMeta
    {
        string[] _metaFields;
        /// <summary>
        /// "toggle" The identifier for this meta type
        ///      ex. ///info metafields
        /// </summary>
        public string Identifier { get { return "info"; } }

        public int NumberOfMetaFields { get { return FieldArray.Length; } }

        /// <summary>
        // Meta Fields defines the type of meta data that can be entered behind the "info" keyword in the script being parsed
        //  "info" "name" "description"
        /// </summary>
        public string[] MetaFields
        {
            get
            {
                if (_metaFields == null)
                    _metaFields = new string[FieldArray.Length];

                return _metaFields;
            }
            private set
            {
                _metaFields = value;
            }
        }

        /// <summary>
        /// An array for storing values of whatever is in the meta data.
        /// </summary>
        Type[] FieldArray
        {
            get
            {
                Type[] fieldArray = new Type[]
                {
                    typeof(string),
                    typeof(string),
                    typeof(string)
                };
                
                return fieldArray;
            }
        }
        
        public bool IsAValidField(int index, string field, bool first)
        {
            if (first)
            {
                return field == Identifier;
            }
            else
            {
                return FieldArray[index] == typeof(string);
            }
        }

        public bool IsAValidField(int index, int field, bool first)
        {
            if (first)
            {
                throw new Exception("Passed int for first index, should be string describing IMeta type.");
            }
            else
            {
                return FieldArray[index] == typeof(string);
            }
        }

        public void AddMetaField(int index, int field)
        {
            throw new FormatException();
        }

        public void AddMetaField(int index, string newfield)
        {
            MetaFields[index] = newfield;
        }

        public bool FieldIsInt(int index)
        {
            return false;
        }

        public bool IsIndependent { get { return true; } }  
    }
}
