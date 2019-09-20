using System;

namespace Atividade_2 {
    class Program {
        static void Main (string[] args) {
            float[] vetor1 = new float[10];
            float[] vetor2 = new float[10];
            float[] vetor3 = new float[20];
            int c = 0;
            for (c = 0; c <= 9; c++) {
                Console.Write ($"1º Vetor - Digite o {c+1}º valor: ");
                vetor1[c] = float.Parse (Console.ReadLine ());
            }
            for (c = 0; c <= 9; c++) {
                Console.Write ($"2º Vetor - Digite o {c+1}º valor: ");
                vetor2[c] = float.Parse (Console.ReadLine ());
            }
            for (c = 0; c <= 9; c++) {
                vetor3[c] = vetor1[c];
            }
            for (c = 10; c <= 19; c++) {
                vetor3[c] = vetor2[c - 10];
            }
            for (c = 0; c <= 19; c++) {
                Console.WriteLine ($"A {c+1}ª posição do 3º vetor é: {vetor3[c]}");
            }

        }
    }
}