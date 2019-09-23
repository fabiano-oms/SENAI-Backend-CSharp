using System;

namespace Atividade_5 {
    class Program {
        static void Main (string[] args) {
            float[] vetorA = new float[10];
            int c = 0;
            for (c = 0; c <= 9; c++) {
                vetorA[c] = c * 2;
            }
            for (c = 0; c <= 9; c++){
            Console.WriteLine ($"O dobro do índice: {c} do vetor é: {vetorA[c]}");
            }
        }
    }
}