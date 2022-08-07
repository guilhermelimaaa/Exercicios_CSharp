using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int numA;
            int numB;
            int numC;
            int numD;

            int adicao01;
            int adicao02;
            int adicao03;
            int adicao04;
            int adicao05;
            int adicao06;

            int mult01;
            int mult02;
            int mult03;
            int mult04;
            int mult05;
            int mult06;



            //codigo
            Console.WriteLine("Digite o valor do primeiro número (número A)");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número (número B)");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro número (número C)");
            numC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do quarto número (número D)");
            numD = Convert.ToInt32(Console.ReadLine());

            adicao01 = (numA + numB);
            adicao02 = (numA + numC);
            adicao03 = (numA + numD);
            adicao04 = (numB + numC);
            adicao05 = (numB + numD);
            adicao06 = (numC + numD);

            mult01 = (numA * numB);
            mult02 = (numA * numC);
            mult03 = (numA * numD);
            mult04 = (numB * numC);
            mult05 = (numB * numD);
            mult06 = (numC * numD);


            Console.WriteLine("Aqui estão as operacões com os números digitados: ");
            Console.WriteLine("Adicao 1 " + adicao01);
            Console.WriteLine("Adicao 2 " + adicao02);
            Console.WriteLine("Adicao 3 " + adicao03);
            Console.WriteLine("Adicao 4 " + adicao04);
            Console.WriteLine("Adicao 5 " + adicao05);
            Console.WriteLine("Adicao 6 " + adicao06);

            Console.WriteLine("Multiplicacao 1 " + mult01);
            Console.WriteLine("Multiplicacao 2 " + mult02);
            Console.WriteLine("Multiplicacao 3 " + mult03);
            Console.WriteLine("Multiplicacao 4 " + mult04);
            Console.WriteLine("Multiplicacao 5 " + mult05);
            Console.WriteLine("Multiplicacao 6 " + mult06);

            Console.ReadKey();






        }
    }
}
