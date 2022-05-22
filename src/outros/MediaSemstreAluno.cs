/**
Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente 
às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para 
cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média 
for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for 
inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 
5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. 
Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média 
(some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a
mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", 
(caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após 
ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final 
para esse aluno.

Entrada
A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

Saída
Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas 
conforme a descrição do problema. Não esqueça de imprimir o enter após o final de cada linha, 
caso contrário obterá "Presentation Error".
**/

namespace exerciciosDotNet.src.outros
{
    public class MediaSemstreAluno
    {
        public static void Executar()
        {
            double a, b, c, d, avg;
            Console.Write("Digite as notas das N1, N2, N3 e N4 separadas por um espaço em branco:");
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]) * 0.2;
            b = double.Parse(values[1]) * 0.3;
            c = double.Parse(values[2]) * 0.4;
            d = double.Parse(values[3]) * 0.1;

            avg = a + b + c + d;
            Console.WriteLine("Media: " + avg.ToString("0.0"));
            if (avg > 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (avg < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (avg >= 5 && avg <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Digite a nota do exame:");
                double e = double.Parse(Console.ReadLine());
                avg = (avg + e) / 2;
                Console.WriteLine("Nota do exame: " + e.ToString("0.0"));
                if (avg >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if (avg < 5)
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + avg.ToString("0.0"));
            }

            Console.ReadKey();
        }
    }
}