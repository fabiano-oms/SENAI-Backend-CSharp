using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float ex4_real, ex4_cot, ex4_conv;
            Console.Write("Digite o valor a ser convertido: R$ ");
            ex4_real = float.Parse(Console.ReadLine());
            Console.Write("Digite a cotação de 1 US$:R$ ");
            ex4_cot = float.Parse(Console.ReadLine());
            ex4_conv = (ex4_real/ex4_cot);
            Console.WriteLine("A quantidade convertida é: US$ " + ex4_conv);
        }
    }
}
