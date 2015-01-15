using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValuesh.BLL
{
    public class IValueshInterpreter
    {
        public String Text { get; set; }

        public IValueshInterpreter(String text)
        {
            this.Text = text;
        }

        public int ContarPreposicoes()
        {
            return (from palavra in this.Text.Split(' ').ToList()
                    where palavra.IndexOf('m') == -1 && palavra.Length == 3 && IsFoo(palavra[2])
                    select palavra).Count();
        }

        public int ContarVerbos()
        {
            return ObtemVerbos().Count();
        }

        public int ContarVerbosPrimeiraPessoa()
        {
            return (from verbo in ObtemVerbos()
                    where IsFoo(verbo[0])
                    select verbo).Count();
        }

        private Boolean IsFoo(char letra)
        {
            return "tswlh".IndexOf(letra) >= 0;
        }

        private List<String> ObtemVerbos()
        {
            return (from palavra in this.Text.Split(' ').ToList()
                    where palavra.Length >= 8 && IsFoo(palavra[palavra.Length - 1])
                    select palavra).ToList();
        }
    }
}
