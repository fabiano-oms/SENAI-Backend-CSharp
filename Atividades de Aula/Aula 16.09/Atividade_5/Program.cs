using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex5_num1, ex5_num2, ex5_num3;
            Console.WriteLine("Escreva 3 números inteiros respectivamente:");
            ex5_num1 = int.Parse(Console.ReadLine());
            ex5_num2 = int.Parse(Console.ReadLine());
            ex5_num3 = int.Parse(Console.ReadLine());
            if(ex5_num1>ex5_num2 && ex5_num1>ex5_num3){
                Console.WriteLine($"O maior número é o: {ex5_num1}");
            }
            else if(ex5_num2>ex5_num1 && ex5_num2>ex5_num3){
                Console.WriteLine($"O maior número é o: {ex5_num2}");
            }
            // (ex5_num3>ex5_num1 && ex5_num3>ex5_num2)
            else{
                Console.WriteLine($"O maior número é o: {ex5_num3}");
            }
        }
    }
}
