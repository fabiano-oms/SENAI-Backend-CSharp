using System;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float ex6_sal, ex6_fat, ex6_total;
            Console.Write("Digite o valor do seu salário: R$ ");
            ex6_sal = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da sua fatura: R$ ");
            ex6_fat = float.Parse(Console.ReadLine());
            ex6_total = (ex6_sal-ex6_fat);
            Console.WriteLine("O valor restante após o pagamento é de: R$ " + ex6_total);
        }
    }
}
