using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            int ex3_num1, ex3_num2;
            Console.WriteLine("Escreva 2 números inteiros respectivamente:");
            ex3_num1 = int.Parse(Console.ReadLine());
            ex3_num2 = int.Parse(Console.ReadLine());
            if(ex3_num1>ex3_num2){
                Console.WriteLine($"O maior número é o: {ex3_num1}");
            }
            else{
                Console.WriteLine($"O maior número é o: {ex3_num2}");
            }















            // int[] vlr = new int[10];
            // int v=0;
            // int maior = -1;
            // int ind = 0;

            // for(int i=0; i<=9; i++){
            //     v = i+1;
            //     Console.Write("Digite o " + v + "° valor: ");
            //     vlr[i] = int.Parse(Console.ReadLine());

            //     if(vlr[i] > maior){
            //         maior = vlr[i];
            //         ind = i;
            //     }
            // }

            // Console.WriteLine("O maior valor é: " + maior);
            // Console.WriteLine("O indicie é: " + ind);
        }
    }
}
