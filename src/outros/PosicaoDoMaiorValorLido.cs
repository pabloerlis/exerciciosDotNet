/**
Você recebeu o desafio de ler 10 valores inteiros. Apresente então o maior valor lido e a 
posição dentre os 10 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
**/

namespace exerciciosDotNet.src.outros
{
    public class PosicaoDoMaiorValorLido
    {
        public static void Executar()
        {
            int n;
            int maior = 0;
            int posicao = 0;
            for (int i = 1; i <= 10; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                    posicao = i;
                }
            }
            Console.WriteLine($"O maior número fornecido é: {maior}");
            Console.WriteLine($"E sua posição é: {posicao}");
            Console.ReadKey();
        }
    }
}