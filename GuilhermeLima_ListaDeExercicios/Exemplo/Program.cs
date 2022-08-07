using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            inteiro = Convert.ToInt32(Console.ReadLine());
            //inteiro = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero digitado foi " + inteiro);
            Console.ReadKey(); //espera apertar uma tecla para continuar
        }
    }
}
