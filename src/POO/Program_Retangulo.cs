namespace exerciciosDotNet.src.POO
{
    public class Program_Retangulo
    {
        public static void Executar()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Calcula a área de um retângulo");

            Console.Write("Informe a altura do triângulo: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a base do triângulo: ");
            retangulo.BaseRet = Convert.ToDouble(Console.ReadLine());

            retangulo.ExibirPropriedades();
        }
    }
}