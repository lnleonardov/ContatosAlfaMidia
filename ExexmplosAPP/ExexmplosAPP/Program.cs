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


    }
}
