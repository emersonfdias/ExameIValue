using IValuesh.BLL;
using IValuesh.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValuesh.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataReader reader = DataReaderFactory.CreateDataReader(DataReaderType.TextFile);
            String textoA = reader.GetAll(ConfigurationManager.AppSettings.Get("PATH_TEXTO_A")).ToString();
            String textoB = reader.GetAll(ConfigurationManager.AppSettings.Get("PATH_TEXTO_B")).ToString();

            IValueshInterpreter interpreter = new IValueshInterpreter(textoB);

            // Questão 1 - Contar preposições
            int qtdPreposicoes = interpreter.ContarPreposicoes();
            Console.WriteLine(String.Format("Quantidade de preposições no texto: {0}", qtdPreposicoes));

            // Questão 2 - Contar verbos
            int qtdVerbos = interpreter.ContarVerbos();
            int qtdPrimeiraPessoa = interpreter.ContarVerbosPrimeiraPessoa();

            Console.WriteLine(String.Format("Quantidade de verbos no texto: {0}", qtdVerbos));
            Console.WriteLine(String.Format("Quantidade de verbos em primeira pessoa no texto: {0}", qtdPrimeiraPessoa));
            Console.ReadLine();
        }
    }
}
