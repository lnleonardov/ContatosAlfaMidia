using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExexmplosAPP
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }

        public List<Telefone> Telefones { get; set; }
        public List<Email> Emails { get; set; }

        public string NomeCompleto(string primeiro, string sobrenome)
        {
            return primeiro + " " + sobrenome;
        }





    }
}
