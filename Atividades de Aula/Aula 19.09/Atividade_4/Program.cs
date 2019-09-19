using System;

namespace Atividade_4 {
    class Program {
        static void Main (string[] args) {
            float numero, soma = 0;
            int cont = 1; 
            int neg = 0;
            string algarism = "";
            do {
                Console.Write ("Digite o " + cont + "º número: ");
                numero = int.Parse (Console.ReadLine ());
                cont++;
                    if(numero >= 0){
                        algarism = algarism + " " + numero.ToString ();
                    }else{
                        soma = soma + numero;
                        neg++;
                    }
            } while (cont <= 5);
            Console.WriteLine($"Os números positivos são:{algarism} e a média dos numeros negativo é: {soma/neg}");
        }
    }
}