/**
Crie um algoritmo/programa no qual o usuário deverá informar o nome e o tipo de cinco animais de 
estimação. O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e peixes foram 
informados.

Regras que deverão ser seguidas para a implementação do algoritmo:

- Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
- Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.
- É obrigatório criar uma classe para representar o Animal.
- A classe deverá possuir dois dados privados (propriedades) para representar as características do 
animal.
- A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos 
dois dados privados (propriedades).
**/

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
                this.tipo = value.ToLower() != "cachorro" && value.ToLower() != "gato" ? "PEIXE" : value.ToUpper();
            }
        }

        public Animal_ControleAnimais() { }

        public Animal_ControleAnimais(string nome, string tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {this.Nome} Tipo: {this.Tipo}");
        }
    }
}