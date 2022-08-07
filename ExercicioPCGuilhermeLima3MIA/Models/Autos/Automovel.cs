using Models.User.Vendedor;
public class Automovel {
    public string placa;
    public Vendedor dono;
    public bool alugado;
    public double valor;

    public Automovel(string placa, Vendedor dono, 
                            bool alugado, double valor) {
        this.placa = placa;
        this.dono = dono;
        this.alugado = alugado;
        this.valor = valor;
    }
}