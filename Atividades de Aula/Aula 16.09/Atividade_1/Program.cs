using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float ex1_sal, ex1_desp;
            Console.Write("Digite o valor do seu salário: R$ ");
            ex1_sal = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da sua fatura: R$ ");
            ex1_desp = float.Parse(Console.ReadLine());
            if(ex1_sal>ex1_desp){
                Console.Write("Saldo em Superávit");
            }
            else{
                Console.Write("Saldo em Déficit"); 
            } 
        }
    }
}
