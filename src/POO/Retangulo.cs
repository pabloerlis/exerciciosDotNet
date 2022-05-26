/**
Exercício área de um retângulo
------------------------------

Crie um programa que exiba para o usuário qual é a área de um retângulo. Para implementar esse 
programa você deverá seguir as seguintes regras:

- O usuário deverá informar para o programa o valor da base e altura do retângulo/quadrado.
- É obrigatório criar/utilizar uma classe para representar o retângulo/quadrado.
- A base e a altura informada pelo usuário deveram ser representadas na classe como propriedades.
- O objeto deverá possuir uma propriedade para exibir o valor da área do retângulo/quadrado
- O objeto deverá possuir um método que exiba os dados de todas as suas propriedades.
**/

namespace exerciciosDotNet.src.POO
{
    public class Retangulo
    {
        public Retangulo()
        {
            this.Altura = 0;
            this.BaseRet = 0;
        }

        public Retangulo(double baseRt, double alturaRt)
        {
            this.BaseRet = baseRt;
            this.Altura = alturaRt;
        }


        private double baseRet;
        public double BaseRet
        {
            get { return baseRet; }
            set
            {
                if (value >= 0) this.baseRet = value;
                else this.baseRet = 0;
            }
        }

        private double altura;
        public double Altura
        {
            get { return altura; }
            set
            {
                if (value >= 0) this.altura = value;
                else this.altura = 0;
            }
        }

        private double area;
        public double Area { get { return this.baseRet * this.altura; } }

        public void ExibirPropriedades()
        {
            Console.WriteLine($"Base: {this.BaseRet}");
            Console.WriteLine($"Altura: {this.Altura}");
            Console.WriteLine($"Área: {this.Area.ToString("F3")}");
            Console.ReadKey();
        }
    }
}