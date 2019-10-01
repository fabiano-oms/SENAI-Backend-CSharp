using System;
using Atividade_4.Models;

namespace Atividade_4.Controllers {
    public class CientificaController : CalculadoraController {
        CalculadoraModel ci = new CalculadoraModel ();
        public double Potencia () {
            double calc = 0;
            calc = Math.Pow (ci.Num1Calc, 2);
            return calc;
        }
    }
}