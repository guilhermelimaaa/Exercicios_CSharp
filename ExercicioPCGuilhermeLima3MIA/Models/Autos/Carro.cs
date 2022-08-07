using Models.User.Vendedor;

namespace Models.Autos.Carro {
    public class Carro : Automovel {
        public Carro(string placa, Vendedor dono, 
                    bool alugado, double valor) : 
                    base(placa, dono, alugado, valor) {}
    }
}