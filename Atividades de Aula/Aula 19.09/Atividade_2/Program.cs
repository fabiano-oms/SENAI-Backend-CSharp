using System;

namespace Atividade_2 {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Digite o número de qual tabuada você deseja calcular: ");
            int tabuada = int.Parse (Console.ReadLine ());
            for (int cont = 1; cont <= 10; cont++) {
                int calculo = (tabuada * cont);
                Console.WriteLine ($"{tabuada} x {cont} = {calculo}");
            }
        }
    }
}