using Models.User.Vendedor;

namespace Models.Autos.Caminhao {
    public class Caminhao : Automovel {
        public Caminhao(string placa, Vendedor dono, 
                    bool alugado, double valor) : 
                    base(placa, dono, alugado, valor) {}
    }
}