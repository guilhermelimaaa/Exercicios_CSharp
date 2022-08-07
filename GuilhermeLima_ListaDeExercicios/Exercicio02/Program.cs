using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double cotDollar;
            double valorEmDollar;
            double conversor;
            double resultado;

            //codigo
            Console.WriteLine("Digite a cotação atual do Dólar");
            cotDollar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cotação do Dólar Americano " + DateTime.Now +" "+ cotDollar + " Real Brasileiro");
            Console.WriteLine("Digite o valor em Dólar desejado");
            valorEmDollar = Convert.ToDouble(Console.ReadLine());
            conversor = (valorEmDollar * cotDollar);
            Console.WriteLine("O Valor em real desta quantia é " + conversor);
            Console.ReadKey();



        }
    }
}
