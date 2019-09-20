using System;

namespace Aula4 {
    class Program {
        static void Main (string[] args) {
            double[] media = new double[10];
            for (int i = 1; i <= 10; i++) {
                Console.Write ($"Digite a {i}ª média: ");
                media[i] = double.Parse (Console.ReadLine ());
            }
            Console.WriteLine (media[3]);
            Console.WriteLine ();
            for (int i = 0; i <= (media.Length - 1); i++){
                Console.WriteLine($"A média é: {media[i]}");
            }
        }
    }
}