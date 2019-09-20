using System;

namespace Atividade_3 {
    class Program {
        static void Main (string[] args) {
            string[] registro1 = new string[12];
            string[] registro2 = new string[12];
            string[] registro3 = new string[12];
            float[] registro4 = new float[12];
            int c = 0;
            for (c = 0; c <= 11; c++) {
                Console.WriteLine ($"Digite as informações do {c+1}º produto:");
                Console.Write ("Nome: ");
                registro1[c] = (Console.ReadLine ());
                Console.Write ("Cor: ");
                registro2[c] = (Console.ReadLine ());
                Console.Write ("Tamanho: ");
                registro3[c] = (Console.ReadLine ());
                Console.Write ("Preço R$: ");
                registro4[c] = float.Parse (Console.ReadLine ());
            }
            for (c = 0; c <= 11; c++) {
                Console.WriteLine (
                    $"As informações do {c+1}º produto são:\nNome: {registro1[c]} Cor: {registro2[c]} Tamanho: {registro3[c]} Preço: R$ {registro4[c]}");
            }
        }
    }
}