using System;

namespace Atividade_2 {
    class Program {
        static void Main (string[] args) {
            ImprimeDiaSemana ();
        }

        static void ImprimeDiaSemana () {
            System.Console.WriteLine (DateTime.Now.DayOfWeek);
        }
    }
}