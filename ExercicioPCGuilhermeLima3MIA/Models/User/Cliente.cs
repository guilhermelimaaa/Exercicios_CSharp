namespace Models.User.Cliente
{
    public class Cliente : Usuario
    {
        public Cliente(string nome, string cpf) : base(nome, cpf) { }


        //Methods of Client 
        public string efetuarAluguel(Automovel auto) {
            if(auto != null) {
                this.automovel.Add(auto);
                return "\n\nO cliente: " + this.cpf + " \nAlugou com sucesso o carro de placa: " + auto.placa;
            }

            return "\nNão foi possível efetuar o alugel do carro: " + auto.placa;
        }
    }
}