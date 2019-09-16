using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da compra: R$ ");
            float ex2_valor = float.Parse(Console.ReadLine());
            if(ex2_valor>=100){
                Console.WriteLine($"O valor da compra com descontos é: {(ex2_valor-25)}");
            }
            else{
                Console.WriteLine($"Você não possui descontos, o valor da compra é: {ex2_valor}");
            }
        }
    }
}
