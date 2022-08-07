using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double raio;
            double altura;
            double volume;

            //codigo
            Console.WriteLine("Digite o raio da lata de óleo (em cm)");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura da lata de óleo (em cm)");
            altura = Convert.ToDouble(Console.ReadLine());
            volume = (3.14159 * raio * raio * altura);
            Console.WriteLine("O Volume da lata de óleo é " + volume);

            Console.ReadKey();



        }
    }
}
