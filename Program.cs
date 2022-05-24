﻿using exerciciosDotNet.src.Fundamentos;
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
                {"Poligono Regular", PoligonoRegular.Executar},
                {"Posição do maior valor fornecido", PosicaoDoMaiorValorLido.Executar},
                {"Multiplicação simples", MultiplicacaoSimples.Executar},
                {"Média de consumo - competição", MediaConsumoCompeticao.Executar},
                {"Média Semestral Aluno - Exame - Aprovado - Reprovado", MediaSemstreAluno.Executar},
                {"Multiplos de 2, 3, 4 e 5 a partir de uma lista", MultiplosDe2_3_4_5.Executar},
                {"Retorna Mês do ano a partir de uma entrada", MesesDoAno.Executar},
                {"Quadrado e ao Cubo", QuadradoEAoCubo.Executar},
                {"Soma pares consecutivos", SomaParesConsecutivos.Executar},
                {"Contagem de cédulas de dinheiro", ContagemCedulas.Executar},
                {"Área do triângulo ou o prerímetro caso não seja um", Triangulo.Executar},
                {"Lista(s) de compras sem repetir item", ListaCompras.Executar},
                {"POO Maior idade", Program_MaiorIdade.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}