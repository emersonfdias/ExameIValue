using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValuesh.DAL
{
    public interface IDataReader
    {
        /// <summary>
        /// Retorna todos os objetos encontrados na fonte de dados
        /// </summary>
        /// <param name="connectionString">Pode representar um caminho para um arquivo de texto, uma connection string para um banco de dados ou mesmo a url de um webservice</param>
        object GetAll(String connectionString);
    }
}
