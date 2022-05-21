using exerciciosDotNet.src.Fundamentos;
using exerciciosDotNet.src.outros;

namespace exerciciosDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new exerciciosDotNet(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Média nota com peso - Outros", MediaNotaComPeso.Executar},
                {"Área da esfera - Outros", AreaEsfera.Executar},
                {"Poligono Regular", PoligonoRegular.Executar},
                {"Posição do maior valor fornecido", PosicaoDoMaiorValorLido.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}