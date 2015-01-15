using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValuesh.DAL
{
    public class DataReaderFactory
    {
        public static IDataReader CreateDataReader(DataReaderType type)
        {
            switch (type)
            {
                case DataReaderType.TextFile: return new TextFile();
                default: return null;
            }
        }
    }

    public enum DataReaderType
    {
        TextFile
    }
}
