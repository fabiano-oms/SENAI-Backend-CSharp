using System;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex7_pass;
            float ex7_total;
            Console.Write("Digite a quantidade de passageiros: ");
            ex7_pass = int.Parse(Console.ReadLine());
            ex7_total = (ex7_pass*4.3f);
            Console.WriteLine("O total de dinheiro arrecadado é: R$ " + ex7_total);
        }
    }
}
