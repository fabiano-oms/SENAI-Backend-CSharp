using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor total a ser pago: R$ ");
            float valor = float.Parse(Console.ReadLine());
            if(valor>=100 && valor<=1000){
                Console.WriteLine($"O valor total a ser pago com desconto é de: {(valor*0.85f)}");
            }
            else{
                Console.WriteLine($"Você não possui descontos, o valor a ser pago é de: R$ {valor}");
            }
        }
    }
}
