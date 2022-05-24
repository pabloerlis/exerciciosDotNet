/**
Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas.
O programa deverá informar o nome da pessoa que possuir a maior idade.
**/
namespace exerciciosDotNet.src.POO
{
    public class Program_MaiorIdade
    {
        public static void Executar()
        {
            Pessoa_MaiorIdade p1 = new Pessoa_MaiorIdade();
            Pessoa_MaiorIdade p2 = new Pessoa_MaiorIdade();
            Pessoa_MaiorIdade p3 = new Pessoa_MaiorIdade();

            Console.WriteLine("Determina qual pessoa dentre as três é a mais velha");
            Console.WriteLine("Qual o nome da primeira pessoa:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {p1.Nome}:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome da segunda pessoa:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {p2.Nome}:");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome da terceira pessoa:");
            p3.Nome = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {p3.Nome}:");
            p3.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade & p1.Idade > p3.Idade)
            {
                Console.WriteLine("A pessoa mais velha é:");
                p1.ExibirDados();
            }
            else if (p2.Idade > p1.Idade && p2.Idade > p3.Idade)
            {
                Console.WriteLine("A pessoa mais velha é:");
                p2.ExibirDados();
            }
            else if (p3.Idade > p2.Idade && p3.Idade > p1.Idade)
            {
                Console.WriteLine("A pessoa mais velha é:");
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("Os três possuem a mesma idade.");
            }

            Console.ReadKey();

        }
    }
}