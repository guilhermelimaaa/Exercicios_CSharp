using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double distancia;
            double tempo;
            int velocidade;
            double litrosUsados;

            //codigo
            Console.WriteLine("Digite o tempo gasto pelo automóvel (em horas)");
            tempo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a velocidade do automóvel (em Km/h) ");
            velocidade = Convert.ToInt32(Console.ReadLine());
            distancia = (tempo * velocidade);
            litrosUsados = (distancia / 12);
            Console.WriteLine("A Velocidade média era de: " + velocidade + "Km/h");
            Console.WriteLine("O Tempo gasto foi de " + tempo + " horas");
            Console.WriteLine("A Distância percorrida foi de " + distancia + "Km");
            Console.WriteLine("A Quantidade de combustível usada foi de: " + litrosUsados + " litros");

            Console.ReadKey();


        }
    }
}
