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
            AdicionarTelefone(pessoa, "+55 51 99999-9999");


            Console.WriteLine($"Nome: {pessoa.Nome}\nCPF: {pessoa.CPF}");

            Console.WriteLine("Nome Completo: {0}", pessoa.NomeCompleto(pessoa.Nome, pessoa.Sobrenome));

            Console.WriteLine($"Telefone 1:{pessoa.Telefones[0].Numero}");
            Console.WriteLine($"Telefone 2:{pessoa.Telefones[1].Numero}");
            Console.WriteLine($"Telefone 3:{pessoa.Telefones[2].Numero}");

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

    }
}
