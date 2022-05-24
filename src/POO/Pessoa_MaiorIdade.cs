namespace exerciciosDotNet.src.POO
{
    public class Pessoa_MaiorIdade
    {
        private string nome = "";
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }
        private int idade = 0;

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value < 0 ? 0 : value; }
        }

        public Pessoa_MaiorIdade() { }

        public Pessoa_MaiorIdade(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Idade: {this.Idade}");
        }
    }
}