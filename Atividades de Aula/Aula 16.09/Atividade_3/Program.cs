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
        }
    }
}
