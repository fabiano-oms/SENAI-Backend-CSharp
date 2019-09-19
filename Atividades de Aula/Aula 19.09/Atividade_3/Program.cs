using System;

namespace Atividade_3 {
    class Program {
        static void Main (string[] args) {
            float numero = 0;
            int cont = 1;
            int multi = 0;
            string algarism = ""; 
            Console.Write ("Digite um número: ");
            numero = float.Parse (Console.ReadLine ());
            do {
                cont++;
                multi = cont % 5;
                if (multi == 0) {
                    algarism = algarism + " " + cont.ToString ();
                }
            } while (cont <= numero);
            Console.WriteLine ($"Os multiplos de 5 no intervalo de 1 à {numero} são:{algarism}");
        }
    }
}