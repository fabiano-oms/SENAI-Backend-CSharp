using System;
using Atividade_4.Controllers;

namespace Atividade_4 {
    class Program {
        static void Main (string[] args) {
            CalculadoraController calculos = new CalculadoraController ();

            calculos.Calculando();
        }
    }
}