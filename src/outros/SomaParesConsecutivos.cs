/**
O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0. Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.

Entrada
O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

Saída
Imprima a saida conforme a explicação acima e o exemplo abaixo.

 
Exemplo de Entrada	Exemplo de Saída
4                   40
11                  80
0
**/

namespace exerciciosDotNet.src.outros
{
    public class SomaParesConsecutivos
    {
        public static void Executar()
        {
            while (true)
            {
                Console.Write("Digite um número para calcular ou '0' para sair: ");
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine(x + (x + 2) + (x + 4) + (x + 6) + (x + 8));
                    }
                    else
                    {
                        int impar = x + 1;
                        Console.WriteLine(impar + (impar + 2) + (impar + 4) + (impar + 6) + (impar + 8));
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}