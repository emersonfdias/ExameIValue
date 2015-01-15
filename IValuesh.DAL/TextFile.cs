using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValuesh.DAL
{
    public class TextFile : IDataReader
    {
        public object GetAll(String connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new ArgumentException("O parâmetro 'connectionString' não pode ser nulo");

            using (StreamReader file = new StreamReader(connectionString))
            {
                return file.ReadToEnd();
            }
        }
    }
}
