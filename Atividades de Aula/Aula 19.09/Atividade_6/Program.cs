using System;

namespace Atividade_6 {
    class Program {
        static void Main (string[] args) {
            int num1, num2, num3, cont, troca;

            for (cont = 0; cont < 20; cont++) {
                num1 = 0;
                num2 = 1;
                for (troca = 0; troca < cont; troca++) {
                    num3 = num1;
                    num1 = num2;
                    num2 = num3 + num2;
                }
                Console.WriteLine (num1);
            }
        }
    }
}