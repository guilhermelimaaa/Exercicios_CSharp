using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int idadeAnos;
            int idadeMeses;
            int idadeDias;
            int totalDias;

            //codigo
            Console.WriteLine("Digite a idade desejada (em anos)");
            idadeAnos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a idade desejada (em meses)");
            idadeMeses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a idade desejada (em dias)");
            idadeDias = Convert.ToInt32(Console.ReadLine());
            totalDias = ((idadeAnos * 365 + idadeMeses * 30) + idadeDias);
            Console.WriteLine("A Idade digitada apenas em dias é de: " + totalDias + " dias");

            Console.ReadKey();
        }
    }
}
