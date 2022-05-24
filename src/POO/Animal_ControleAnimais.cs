namespace exerciciosDotNet.src.POO
{
    public class Animal_ControleAnimais
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private string tipo;
        public string Tipo
        {
            get { return this.tipo; }

            set
            {
                this.tipo = value.ToLower() != "cahorro" && value.ToLower() != "gato" ? "Peixe" : value.ToUpper();
            }
        }

        public Animal_ControleAnimais() { }

        public Animal_ControleAnimais(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {this.Nome} Tipo: {this.Tipo}");
        }
    }
}