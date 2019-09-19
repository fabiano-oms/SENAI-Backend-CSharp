using System;

namespace Atividade_7 {
    class Program {
        static void Main (string[] args) {
            int cont = 1;
            int numero = 0;
            int multi = 0;
            int impar = 0;
            int prod = 1;
            int soma = 0;
            string algarism = "";

            do {
                Console.Write ("Digite o " + cont + "º número: ");
                numero = int.Parse (Console.ReadLine ());
                cont++;
                impar = numero % 2;
                multi = numero % 3;
                if (numero > 0) {
                    if (multi == 0) {
                        prod = prod * numero;
                    }
                    if (impar != 0) {
                        soma = soma + numero;
                    }
                } else {
                    algarism = algarism + " " + numero.ToString ();
                }
            } while (cont <= 6);
            Console.WriteLine ($"A soma dos impares é: {soma}\nO produto dos números multiplos de 3 digitados é: {prod}\nOs números negativos são:{algarism}");
        }
    }
}