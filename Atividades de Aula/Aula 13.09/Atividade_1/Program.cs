using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float ex1_num, ex1_triplo;
            Console.WriteLine("Digite um número, para o cálculo: ");
            ex1_num = float.Parse(Console.ReadLine());
            ex1_triplo = (ex1_num*3);
            Console.WriteLine("O triplo do número fornecido é: " + ex1_triplo);
        }
    }
}
