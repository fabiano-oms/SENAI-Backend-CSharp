using System;

namespace Atividade_6 {
    class Program {
        static void Main (string[] args) {
            
            //Fibonacci com FOR-----------------------------------------------
            int num1 = 0, num2 = 1, num3, contador;
            for (contador = 1; contador <= 20; contador++) {
                Console.WriteLine (num1);
                num3 = num1;
                num1 = num2;
                num2 = num3 + num2;
            }
            
            //----------------------------------------------------------------

            // //Fibonacci com DO/WHILE-------------------------------------------
            // int contador = 1;
            // int acumulador = 0;
            // int n1 = 0, n2 = 1, n3;
            // do{
            //     contador++;
            //     if(n1 == 0){
            //         Console.WriteLine(+n1);
            //     }
            //     if(acumulador<contador){
            //         n3 = n1;
            //         n1 = n2;
            //         n2 = n2+n3;
            //         acumulador++;
            //     }
            //     Console.WriteLine(n1);
            // } while( contador<20 );
            //     // n3 = 0
            //     // n1 = 1
            //     // n2 = 1 + 0 = 1      RESP: 1

            //     // n3 = 1
            //     // n1 = 1
            //     // n2 = 1 + 1 = 2      RESP: 1

            //     // n3 = 1
            //     // n1 = 2
            //     // n2 = 2 + 1 = 3      RESP: 2

            //     // n3 = 2
            //     // n1 = 3
            //     // n2 = 3 + 2 = 5      RESP: 3 ...
            // //-----------------------------------------------------------


            // //Fibonacci com WHILE---------------------------------------
            // int contador = 1;
            // int n1 = 0, n2 = 1, n3;
            // while( contador<=20 ){;
            // contador++;
            // Console.WriteLine(n1);
            //     n3 = n1;
            //     n1 = n2;
            //     n2 = n2+n3;
            // }
            //     //n3 = 0            RESP: 0
            //     //n1 = 1
            //     //n2 = 1 + 0 = 1

            //     //n3 = 1            RESP: 1
            //     //n1 = 1
            //     //n2 = 1 + 1 = 2

            //     //n3 = 1            RESP: 1
            //     //n1 = 2
            //     //n2 = 2 + 1 = 3

            //     //n3 = 2            RESP: 2
            //     //n1 = 3
            //     //n2 = 3 + 2 = 5      
            // //-----------------------------------------------------
        }
    }
}