using System;

namespace Atividade_7 {
    class Program {
        static void Main (string[] args) {
            float[] vetorA = new float[10];
            int c = 0;
            float maior = 0; // Para evitar que valores negativos não entrem na comparação
            int posic = 0;
            for (c = 0; c <= 9; c++) {
                Console.Write ($"Digite o {c+1}º valor: ");
                vetorA[c] = float.Parse (Console.ReadLine ());
                if (c == 0){
                    maior = vetorA[0];
                }
                if (vetorA[c] > maior) {
                    maior = vetorA[c];
                    posic = (c+1);
                }
            }
            Console.WriteLine ("O maior número digitado está na " + posic + "ª posição e seu valor é: " + maior);
        }
    }
}