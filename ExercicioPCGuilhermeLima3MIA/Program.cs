using System;
using Models.User.Cliente;
using Models.User.Vendedor;
using System.Collections.Generic;

namespace LocadoraCarros

{
    class Program
    {
        private static Vendedor Arlindo;
        private static Cliente Jubileu;
        private static List<Vendedor> vendedores = new List<Vendedor>();
        private static string tipo = "";
        private static string placa = "";
        private static double valor = 0.0;

        static string retirarCaracteres(string inputString) {
            inputString = inputString.Replace(".", "");
            inputString = inputString.Replace("/", "");
            inputString = inputString.Replace("-", "");
            inputString = inputString.Replace(",", "");
            return inputString.Trim();
        }

        static void captarAutomovel()
        {
            Console.WriteLine("\nQual o tipo do automóvel? \n1 - Carro \n2 - Caminhão " +
                                "\nInforme o número da opção: ");

            tipo = Console.ReadLine();

            Console.WriteLine("Informe a placa: ");
            placa = retirarCaracteres(Console.ReadLine());

            Console.WriteLine("Informe qual o valor da locação: ");
            valor = int.Parse(Console.ReadLine());
        }

        public static string alugarVeiculo(Cliente cliente, string placaAuto, string cpfVendedor)
        {
            for (int i = 0; i < vendedores.Count; i++)
            {
                if (vendedores[i].cpf == cpfVendedor)
                {
                    List<Automovel> auto = vendedores[i].automovel;
                    for (int c = 0; c < auto.Count; c++)
                    {
                        if (auto[c].placa == placaAuto && !auto[c].alugado)
                        {
                            auto[c].alugado = true;
                            return cliente.efetuarAluguel(auto[c]);
                        }
                    }
                }
            }

            return "Não foi possível alugar o carro: " + placaAuto;
        }

        public static void mockPerfis()
        {
            Arlindo = new Vendedor("Arlindo", "123");
            Jubileu = new Cliente("Jubileu", "321");

            
        }

        public static void alterarCpf()
        {
            Console.WriteLine("\nOs CPF's padrões são: \nArlindo -> " + Arlindo.cpf +
                                "\nJubileu -> " + Jubileu.cpf);

            Console.WriteLine("\nDeseja alterar o cpf do vendedor? s - sim // n - não:");
            string opcao = Console.ReadLine().ToLower().Trim();
            if (opcao == "s")
            {
                Console.WriteLine("\nInforme o novo CPF: ");
         
                Console.WriteLine("CPF alterado. Novo cpf: " + Arlindo.cpf);
            }

            Console.WriteLine("\nDeseja alterar o cpf do cliente? s - sim // n - não:");
            opcao = Console.ReadLine().ToLower().Trim();
            if (opcao == "s")
            {
                Console.WriteLine("\nInforme o novo CPF: ");
                Jubileu.cpf = retirarCaracteres(Console.ReadLine());
                Console.WriteLine("CPF alterado. Novo cpf: " + Jubileu.cpf);
            }
        }

        static void Main(string[] args)
        {
           
            mockPerfis();
            alterarCpf();
            string continuar = "";

            Console.WriteLine("\n\nFunções de vendedores \n===============================");
            do
            {
                captarAutomovel();
       
                Console.WriteLine("\nDeseja adicionar mais? \ns - Sim // n - Não");

                continuar = Console.ReadLine().ToLower().Trim();
                Console.Clear();
            } while (continuar == "s");

            Console.WriteLine("\n\nFunções de clientes \n===============================");
            do
            {
                Console.WriteLine("Para alugar um veículo informe a placa do veículo desejado: ");
                string placa = Console.ReadLine();

                Console.WriteLine("\nInforme o CPF do dono deste veículo: ");
                string cpf = Console.ReadLine();

                string response = alugarVeiculo(Jubileu, placa, cpf);
                Console.WriteLine(response);

                Console.WriteLine("\nDeseja alugar mais algum veículo? s - sim // n -não");
                continuar = Console.ReadLine();
            } while (continuar == "s");
        }
    }
}
