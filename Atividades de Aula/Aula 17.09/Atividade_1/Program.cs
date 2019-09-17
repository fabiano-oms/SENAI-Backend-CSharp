using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex1_resposta = "";
            Console.WriteLine(
                "Digite o número do seu pedido \n" +
                "MENU: \n" +
                "1 - Hamburger \n" +
                "2 - X-Salada \n" +
                "3 - X-Burger \n" +
                "4 - X-Bacon"
            );
            int ex1_pedido = int.Parse(Console.ReadLine());
            switch(ex1_pedido){
                case 1:
                ex1_resposta = "Hamburger";
                break;
                case 2:
                ex1_resposta = "X-Salada";
                break;
                case 3:
                ex1_resposta = "X-Burger";
                break;
                case 4:
                ex1_resposta = "X-Bacon";
                break;
                default:
                ex1_resposta = "Opção Inválida! Somente de 1 à 4 são válidas";
                break;
            }
            Console.WriteLine($"Pedido em espera: {ex1_resposta}");
        }
    }
}
