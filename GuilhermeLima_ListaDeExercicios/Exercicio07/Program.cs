using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int tempFahrenheit;
            int tempCelsius;

            //codigo
            Console.WriteLine("Digite a temperatura em Fahrenheit a ser convertida");
            tempFahrenheit = Convert.ToInt32(Console.ReadLine());
            tempCelsius = ((tempFahrenheit - 32) * 5 / 9);
            Console.WriteLine("A Temperatura em Celsius é de: " + tempCelsius + "C");

            Console.ReadKey();
        }
    }
}
