using System;
using System.Collections.Generic;

using exerciciosDotNet.src.Fundamentos;

namespace exerciciosDotNet {
    class Program {
        static void Main(string[] args) {
            var central = new exerciciosDotNet(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}