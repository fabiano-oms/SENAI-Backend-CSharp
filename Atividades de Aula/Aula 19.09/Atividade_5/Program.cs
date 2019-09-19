using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cont = 1;
            float soma = 0;
            Console.Write ("Digite o número de funcionários na empresa: ");
            numero = int.Parse (Console.ReadLine ());
            do {
                cont++;
                Console.Write("Digite o salário " + cont + "º funcionário R$: ");
                float salario = float.Parse(Console.ReadLine());
                soma = soma + salario;
            } while (cont <= numero);
            Console.WriteLine($"A média de salário dos {numero} funcionários é R$: {soma/numero}");
        }
    }
}
