using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int tempCelsius;
            int tempFahrenheit;

            //codigo
            Console.WriteLine("Digite a temperatura em Celsius a ser convertida");
            tempCelsius = Convert.ToInt32(Console.ReadLine());
            tempFahrenheit = ((9 * tempCelsius + 160) / 5);
            Console.WriteLine("A Temperatura em Fahrenheit é de: " + tempFahrenheit + "F");

            Console.ReadKey();


        }
    }
}
