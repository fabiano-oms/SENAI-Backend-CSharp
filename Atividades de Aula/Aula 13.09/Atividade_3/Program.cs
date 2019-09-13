using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float ex3_sal, ex3_vend, ex3_total;
            Console.Write("Digite o valor do seu salário: R$ ");
            ex3_sal = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor total vendido: R$ ");
            ex3_vend = float.Parse(Console.ReadLine());
            // float 0.5F, double 0.5
            ex3_total = (ex3_sal + (0.05f*ex3_vend));
            Console.WriteLine("O valor total recebido é: R$ " + ex3_total);
        }
    }
}
