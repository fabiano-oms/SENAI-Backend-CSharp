using System;

namespace Atividade_5 {
    class Program {
        static void Main (string[] args) {
            double[] v1 = { 10.4, 9, 8, -7.6, 6, 45, 4.5, 3, 2, 6, 4 };
            Console.WriteLine ($"O valor total é: {ValorTot(v1)}");
        }

        static double ValorTot (double[] vetor) {
            double soma = 0;
            for (int c = 0; c <= vetor.Length - 1; c++){
                soma += vetor[c];
            }
            return soma;
        }
    }
}