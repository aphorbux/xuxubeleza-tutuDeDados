namespace Modelo {
    public class Funcionario {
        public string nome {get; set;}
        public string cargo {get; set;}

        public Funcionario(string nome, string cargo){
            this.nome = nome;
            this.cargo = cargo;
        }
    }
}
