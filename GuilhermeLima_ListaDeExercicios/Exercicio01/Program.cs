using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {   
            //variaveis
            int qtdMin;
            int qtdMax;
            double media;

            //codigo

            Console.WriteLine("Digite o estoque mínimo");
            qtdMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o estoque máximo");
            qtdMax = Convert.ToInt32(Console.ReadLine());
            media = (qtdMax + qtdMin) / 2;
            Console.WriteLine("A Média do estoque é " + media);
            Console.ReadKey();





        }
    }
}
