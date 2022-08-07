using Models.Autos.Carro;
using Models.Autos.Caminhao;
using System;

namespace Models.User.Vendedor
{
    public class Vendedor : Usuario
    {
        public Vendedor(string nome, string cpf) : base(nome, cpf) { }

        //Methods of salesman
        public void disporVeiculoParaAluguel(string placa,
            double valor, string tipo)
        {

            if (tipo == "1")
            {
                Carro carro = new Carro(placa, this, false, valor);
                this.automovel.Add(carro);
                return;
            }
            else if (tipo == "2")
            {
                Caminhao caminhao = new Caminhao(placa, this, false, valor);
                this.automovel.Add(caminhao);
                return;
            }
        }
    }
}