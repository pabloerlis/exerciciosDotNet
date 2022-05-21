/**
Na geometria Euclidiana, um polígono regular é um polígono em que todos os ângulos são iguais 
e todos os lados tem o mesmo comprimento. Um polígono simples é aquele cujos segmentos de reta 
não se interceptam.

Você deve escrever um programa que, dados o número e o comprimento dos lados de um polígono 
regular, mostre seu perímetro.

Entrada
A entrada tem dois inteiros positivos: N e L, que são, respectivamente, o número de lados e o 
comprimento de cada lado de um polígono regular (3 ≤ N ≤ 1000000 and 1 ≤ L ≤ 4000).

Saída
A saída é o perímetro P do polígono regular em uma única linha.
**/

namespace exerciciosDotNet.src.outros
{
    public class PoligonoRegular
    {
        public static void Executar()
        {
            Console.WriteLine(
                "Entrada com dois inteiros positivos: N L, separados por um espaço em branco," +
                "que são, respectivamente, o número de lados e o comprimento de cada lado de um" +
                "polígono regular:");
            string[] v = Console.ReadLine().Split(" ");
            Console.WriteLine(int.Parse(v[0]) * int.Parse(v[1]));
            Console.ReadKey();
        }
    }
}