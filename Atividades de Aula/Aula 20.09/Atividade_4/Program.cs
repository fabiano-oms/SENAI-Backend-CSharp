using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetorA = new string[15];
            string[] vetorB = new string[15];
            string[] vetorC = new string[30];
            int c = 0;
            for (c = 0; c <= 14; c++) {
                Console.Write ($"Vetor A - Digite a {c+1}ª palavra: ");
                vetorA[c] = (Console.ReadLine ());
            }
            for (c = 0; c <= 14; c++) {
                Console.Write ($"Vetor B - Digite a {c+1}ª palavra: ");
                vetorB[c] = (Console.ReadLine ());
            }
            for (c = 0; c <= 14; c++) {
                vetorC[c] = vetorA[c];
            }
            for (c = 15; c <= 29; c++) {
                vetorC[c] = vetorB[c - 15];
            }
            for (c = 0; c <= 29; c++) {
                Console.WriteLine ($"A {c+1}ª palavra do vetor C é: {vetorC[c]}");
            }
        }
    }
}
