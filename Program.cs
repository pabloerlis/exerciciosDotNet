using exerciciosDotNet.src.Fundamentos;
using exerciciosDotNet.src.outros;
using exerciciosDotNet.src.POO;


namespace exerciciosDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDotNet(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Média nota com peso - Outros", MediaNotaComPeso.Executar},
                {"Área da esfera - Outros", AreaEsfera.Executar},
                {"Poligono Regular - Outros", PoligonoRegular.Executar},
                {"Posição do maior valor fornecido - Outros", PosicaoDoMaiorValorLido.Executar},
                {"Multiplicação simples - Outros", MultiplicacaoSimples.Executar},
                {"Média de consumo - competição - Outros", MediaConsumoCompeticao.Executar},
                {"Média Semestral Aluno - Outros", MediaSemstreAluno.Executar},
                {"Multiplos de 2, 3, 4 e 5 a partir de uma lista - Outros", MultiplosDe2_3_4_5.Executar},
                {"Retorna Mês do ano a partir de uma entrada - Outros", MesesDoAno.Executar},
                {"Quadrado e ao Cubo - Outros", QuadradoEAoCubo.Executar},
                {"Soma pares consecutivos - Outros", SomaParesConsecutivos.Executar},
                {"Contagem de cédulas de dinheiro - Outros", ContagemCedulas.Executar},
                {"Área do triângulo ou o prerímetro caso não seja um - Outros", Triangulo.Executar},
                {"Lista(s) de compras sem repetir item - Outros", ListaCompras.Executar},
                {"Maior idade - POO", Program_MaiorIdade.Executar},
                {"Lista de animais - POO", Program_ControleAnimais.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}