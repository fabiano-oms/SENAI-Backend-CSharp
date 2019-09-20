using System;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            float[] vetor = new float[10];
            for (int c = 0; c <= 9; c++) {
                Console.Write ($"Digite o {c+1}º valor: ");
                vetor[c] = float.Parse (Console.ReadLine ());
            }
            for (int c = 0; c <= 9; c++) {
                Console.WriteLine ($"A {c+1}ª posição do vetor é: {vetor[c]}");
            }
            Console.WriteLine ($"A ultima posição multiplicada por 5 é: {vetor[9]*5}");
        }
    }
}