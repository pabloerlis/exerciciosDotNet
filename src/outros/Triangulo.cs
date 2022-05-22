/**
Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, 
calcule o perímetro do triângulo (soma de todos os lados) e apresente a mensagem:

Perimetro = XX.X

Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a 
mensagem:

Area = XX.X

Fórmula da área de um trapézio: AREA = ((A + B) x C) / 2

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal.

 
Exemplo de Entrada	Exemplo de Saída
6.0 4.0 2.0

Area = 10.0

6.0 4.0 2.1

Perimetro = 12.1
**/

namespace exerciciosDotNet.src.outros
{
    public class Triangulo
    {
        public static void Executar()
        {
            double a, b, c;
            Console.Write("Digite os valores separados por espaço: ");
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            double perimetro = a + b + c;
            bool triangulo = a + b > c & a + c > b & b + c > a;
            double areaTrapezio = ((a + b) * c) / 2;
            if (triangulo)
            {
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1")}");
            }
            else
            {
                Console.WriteLine($"Area = {areaTrapezio.ToString("F1")}");
            }
        }
    }
}