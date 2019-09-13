using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex5_nome;
            float ex5_sal, ex5_vend, ex5_total;
            Console.Write("Digite o seu nome: ");
            ex5_nome = Console.ReadLine();
            Console.Write("Digite o valor do seu salário: R$ ");
            ex5_sal = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor total vendido: R$ ");
            ex5_vend = float.Parse(Console.ReadLine());
            ex5_total = (ex5_sal + (0.1f*ex5_vend));
            Console.WriteLine(ex5_nome + ", seu salário fixo foi de: R$ " + ex5_sal + " e seu salário total foi de: R$ " + ex5_total);
        }
    }
}
