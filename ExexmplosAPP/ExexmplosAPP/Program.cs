using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExexmplosAPP
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Início
            Console.WriteLine("Meu Aplicativo\n\n");


            var idade = 18;
            var nomePessoa = "João";
            String nomeDaMae;
            nomeDaMae = "Joana";
            int idadeDaMae;
            idadeDaMae = 42;


            Console.WriteLine("Nome: " + nomePessoa);
            Console.WriteLine("Idade: " + idade.ToString());
            Console.WriteLine("Mãe: " + nomeDaMae);
            Console.WriteLine("Idade: " + idadeDaMae);


            // Funções
            var sobrenome = "Silva";
            Console.WriteLine( "Nome Completo: " + NomeCompleto(nomePessoa, sobrenome) );

            EscreveDiferençaIdade(idadeDaMae, idade);

            Console.WriteLine(value: "\n-------------------------------------\n");

            var pessoa = new Pessoa();
            pessoa.Nome = "Pedro";
            pessoa.Sobrenome = "Santana";
            pessoa.CPF = "123456789";

            //Telefones
            pessoa.Telefones = new List<Telefone>();
            AdicionarTelefone(pessoa, "+55 51 3333-3333");
            AdicionarTelefone(pessoa, "+55 51 99999-9999");
            AdicionarTelefone(pessoa, "+55 51 99999-9991");
            AdicionarTelefone(pessoa, "+55 51 99999-9992");
            AdicionarTelefone(pessoa, "+55 51 99999-9993");
            AdicionarTelefone(pessoa, "+55 51 99999-9994");
            AdicionarTelefone(pessoa, "+55 51 99999-9995");

            // Emails
            pessoa.Emails = new List<Email>();
            AdicionarEmail(pessoa, "123@gmail.com");
            AdicionarEmail(pessoa, "1234@gmail.com");
            AdicionarEmail(pessoa, "12345@gmail.com");
            AdicionarEmail(pessoa, "123456@gmail.com");

            //Logradouros
            pessoa.Logradouros = new List<Logradouro>();
            AdicionarLogradouro(pessoa, "Rua1", "1");
            AdicionarLogradouro(pessoa, "Rua2", "2");
            AdicionarLogradouro(pessoa, "Rua3", "3");
            AdicionarLogradouro(pessoa, "Rua7", "4");




            Console.WriteLine($"Nome: {pessoa.Nome}\nCPF: {pessoa.CPF}");

            Console.WriteLine("Nome Completo: {0}", pessoa.NomeCompleto(pessoa.Nome, pessoa.Sobrenome));

            EscreveNumeros(pessoa);
            EscreveLogradouros(pessoa);
            EscreveEmails(pessoa);
           

            Console.ReadKey();



        }
        static string NomeCompleto(string primeiro, string sobrenome)
        {
            return primeiro + " " + sobrenome;
        }

        static void EscreveDiferençaIdade(int idadeMaisVelho, int idadeMaisNovo)
        {
            Console.WriteLine("Difereça: " + (idadeMaisVelho - idadeMaisNovo).ToString());
        }

        public static void AdicionarTelefone(Pessoa pessoa, string telefone)

        {
            var objetoTelefone = new Telefone();
            objetoTelefone.Numero = telefone;
            pessoa.Telefones.Add(objetoTelefone);

        }
        public static void AdicionarEmail(Pessoa pessoa, string endereco)

        {
            var objetoEmail = new Email();
            objetoEmail.Endereco = endereco;
            pessoa.Emails.Add(objetoEmail);

        }
        public static void AdicionarLogradouro(Pessoa pessoa, string numero, string rua)
        {
            var objetoLogradouro = new Logradouro();
            objetoLogradouro.Numero = numero;
            objetoLogradouro.Rua = rua;
            pessoa.Logradouros.Add(objetoLogradouro);
        }
        public static void EscreveNumeros(Pessoa pessoa)
        {
            for (int i = 0; i < pessoa.Telefones.Count(); i++)
            {
                Console.WriteLine($"Telefone {i + 1}:{pessoa.Telefones[i].Numero}");
            }
        }
        public static void EscreveLogradouros(Pessoa pessoa)
        {
            Console.Write("Emails : ");
            foreach (Email item in pessoa.Emails)
            {
                Console.Write($"{item.Endereco}, ");
            }
        }

        public static void EscreveEmails(Pessoa pessoa)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Logradouros: ");
            foreach (Logradouro item in pessoa.Logradouros)
            {
                Console.WriteLine($"{item.Rua},{item.Numero} ");
            }
        }
    }
}
