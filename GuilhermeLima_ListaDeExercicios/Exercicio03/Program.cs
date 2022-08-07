using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int idVendedor;
            int codPeca;
            double precoPeca;
            int qtdVendida;
            double comissao;

            //codigo
            Console.WriteLine("Qual a identificacão do vendedor ? ");
            idVendedor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o código da peca de roupa ? ");
            codPeca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o preco da peca de roupa ? ");
            precoPeca = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de pecas vendidas ? ");
            qtdVendida = Convert.ToInt32(Console.ReadLine());
            comissao = ((precoPeca * qtdVendida) * 0.005);
            Console.WriteLine("Sua comissão é de " + comissao + "R$");
            Console.ReadKey();


        }
    }
}
