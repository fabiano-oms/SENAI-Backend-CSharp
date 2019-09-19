using System;

namespace Atividade_6 {
    class Program {
        static void Main (string[] args) {
            // int num1, num2, num3, cont, troca;
            // for (cont = 0; cont < 20; cont++) {
            //     num1 = 0;
            //     num2 = 1;
            //     for (troca = 0; troca < cont; troca++) {
            //         num3 = num1;
            //         num1 = num2;
            //         num2 = num3 + num2;
            //     }
            //     Console.WriteLine (num1);
            // }

            int contador = 1;
            int acumulador = 0;
            int n1 = 0, n2 = 1, n3;
            do{
                contador++;
                if(n1 == 0){
                    Console.WriteLine(+n1);
                }
                if(acumulador<contador){
                    n3 = n1;
                    n1 = n2;
                    n2 = n2+n3;
                    acumulador++;
                }
                Console.WriteLine(+n1);
            } while( contador<20 );
        }
    }
}