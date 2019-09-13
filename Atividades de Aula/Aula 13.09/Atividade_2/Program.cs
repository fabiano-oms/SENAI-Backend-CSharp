using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float ex2_num, ex2_porcent, ex2_acres, ex2_valor;
            Console.Write("Digite o preço da mercadoria: R$ ");
            ex2_num = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o % de acréscimo do produto");
            ex2_porcent = float.Parse(Console.ReadLine());
            ex2_acres = (ex2_porcent/100);
            ex2_valor = (ex2_num*(1+ex2_acres));
            Console.WriteLine("O valor com este acréscimo é: " + ex2_valor);
        }
    }
}
