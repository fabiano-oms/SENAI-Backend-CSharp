using System;
using Atividade_2.Controllers;

namespace Atividade_2 {
    class Program {
        static void Main (string[] args) {
            CelularesController celular1 = new CelularesController ();
            Console.Clear();
                celular1.UsandoCelular();
        }
    }
}