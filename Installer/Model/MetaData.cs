using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Model
{
    public class MetaData<T> where T : IMeta
    {
        public T MetaInfo { get; private set; }

        public MetaData(T metaInfo)
        {
            MetaInfo = metaInfo;
        }
    }
}
