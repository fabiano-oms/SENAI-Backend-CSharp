using System;

namespace Atividade_4 {
    class Program {
        static void Main (string[] args) {
            double[] v1 = { 10.4, 9, 8, -7.6, 6, 45, 4.5, 3, 2 };
            System.Console.WriteLine($"O maior valor é: {MaiorPosit(v1)}");
        }

        static double MaiorPosit (double[] vetor) {
            double maior = 0;
            for (int c = 0; c <= vetor.Length - 1; c++) {
                if (c == 0) {
                    maior = vetor[0];
                }
                if (vetor[c] > maior) {
                    maior = vetor[c];
                }
            }
            return maior;
        }
    }
}