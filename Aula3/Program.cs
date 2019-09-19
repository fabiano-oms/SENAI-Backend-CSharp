using System;

namespace Aula3 {
    class Program {
        static void Main (string[] args) {

            // //Laço contado: FOR(inicio do contador; final do contador; incremento) (cont++ de 1 em 1; cont+=2 de 2 em 2;cont+=3 de 3 em 3)
            // for (int cont = 1; cont <= 100; cont++) {
            //     //Verificamos se é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 0-100 - " + cont);
            //     }
            // }

            // for (int cont = 100; cont >= 1; cont--) {
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 100-0 - " + cont);
            //     }
            // }

            // //Laço condicional - WHILE
            // double nota = 0;
            // double soma = 0;
            // int cont = 0;
            // //ToString converte um valor para String
            // while (nota != 1000) {
            //     Console.WriteLine ("Para sair da aplicação digite: 1000");
            //     Console.WriteLine ("Digite a nota de um aluno: ");
            //     nota = double.Parse (Console.ReadLine ());
            //     if (nota != 1000) {
            //         //+= soma todos os valores dentro do loop
            //         soma = soma + nota;
            //         cont++;
            //     }
            // }
            // Console.WriteLine ($"A média das {cont} notas é: {soma/cont}");

            // do{
            //     //Sintax
            // }while(){
            //     //Sintax
            // }

            // int cont = 1;
            // int acum = 0;
            // int numero = 0;
            // Console.WriteLine("Digite 20 números inteiros:");
            // do{
            //     numero = int.Parse(Console.ReadLine());
            //     cont++;
            //         if(numero % 3 == 0){
            //             acum = acum + numero;
            //         }
            // }while(cont<=20);
            // Console.WriteLine($"O acumulo dos números multiplos de 3, digitados durante as 20 tentativas é: {acum}");

            int cont = 1;
            int soma = 0;
            int numeros = 0;
            int multi = 0;
            string algarism = "";

            do {
                Console.Write ("Digite o " + cont + "º número: ");
                numeros = int.Parse (Console.ReadLine ());
                cont++;
                multi = numeros % 3;
                if (multi == 0) {
                    algarism = algarism + " " + numeros.ToString ();
                    soma = soma + numeros;
                }
            } while (cont <= 3);
            Console.WriteLine ($"Os números multiplos de 3 digitados são:{algarism} e a soma é: {soma}");
        }
    }
}