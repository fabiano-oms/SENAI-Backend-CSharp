using System;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            for (int cont = 1; cont <= 100; cont++) {
                int cubo = (cont*cont*cont);
                Console.WriteLine($"O Cubo do valor {cont} é: {cubo}");
            }
        }
    }
}