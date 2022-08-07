
using System.Collections.Generic; 
public class Usuario { 
    public string nome;
    public string cpf;
    public List<Automovel> automovel = new List<Automovel>();

    public Usuario(string nome, string cpf) {
        this.nome = nome;
        this.cpf = cpf;
    }

    public string exibirNomeE_cpf() {
        return "Nome: " + this.nome +
                " \nCPF: " + this.cpf;
    }
}