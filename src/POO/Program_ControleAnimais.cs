namespace exerciciosDotNet.src.POO
{
    public class Program_ControleAnimais
    {
        public static void Executar()
        {
            Animal_ControleAnimais[] animais = new Animal_ControleAnimais[5];

            int cachorro = 0;
            int gato = 0;
            int peixe = 0;

            void PreencherListaCom5Animais()
            {
                for (int i = 1; i <= 5; i++)
                {
                    string nome;
                    string tipo;
                    Console.Write($"Digite o nome do animal {i}: ");
                    nome = Console.ReadLine();
                    Console.Write($"Digite o tipo de animal de {nome}: ");
                    tipo = Console.ReadLine();
                    animais[i - 1] = new Animal_ControleAnimais(nome, tipo);
                    Console.WriteLine("Animal adicionado.");
                    if (animais[i - 1].Tipo == "CACHORRO") cachorro++;
                    if (animais[i - 1].Tipo == "GATO") gato++;
                    if (animais[i - 1].Tipo == "PEIXE") peixe++;
                }
            }

            void MostrarQuantidade()
            {
                Console.WriteLine($"Cachorro: {cachorro}");
                Console.WriteLine($"Gato: {gato}");
                Console.WriteLine($"Peixe: {peixe}");

            }

            PreencherListaCom5Animais();
            MostrarQuantidade();
            Console.ReadKey();
        }
    }
}