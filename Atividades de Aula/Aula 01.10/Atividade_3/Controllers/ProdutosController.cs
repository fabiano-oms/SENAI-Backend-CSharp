using System;
using Atividade_3.Models;

namespace Atividade_3.Controllers
{
    public class ProdutosController
    {
        ProdutoModel prod = new ProdutoModel();

        public void ListarReserva(){
            ReservaProdutoMenu(prod.NomeProduto, prod.QuantidadeProduto);
        }

        public void ReservaProdutoMenu(string[] nome, int[] quant){
            int op = 5;
            int p = 0;
            int v = 100;
            bool voltar = true;
            while (op != 0) {
                if (p < v) {
                    voltar = true;
                }

                System.Console.WriteLine();
                Console.WriteLine (
                    @"MENU: 
                    1 - Cadastrar sua reserva [Nome / Quantidade]
                    2 - Listar suas reservas
                    
                    0 - Sair"
                );
                
                System.Console.WriteLine();
                Console.Write ("Digite uma opção: ");
                op = int.Parse (Console.ReadLine ());

                switch (op) {
                    case 1:
                        //Reservar um produto que terá Nome e Quantidade
                        while (voltar == true) {
                            System.Console.WriteLine();

                            Console.Write ("Insira o nome do " + (p + 1) + "° produto: ");
                            nome[p] = Console.ReadLine ();
                            
                            Console.Write ("Insira a quantidade do " + (p + 1) + "° produto: ");
                            quant[p] = int.Parse (Console.ReadLine ());

                            if (p <= v) {
                                System.Console.WriteLine();

                                Console.Write ("Gostaria de reservar outro produto?\n[true/false]: ");
                                voltar = bool.Parse (Console.ReadLine ());
                                p++;
                            }
                        }
                        break;

                    case 2:
                        //Listar todas as reservas
                        for (int c = 0; c <= (p - 1); c++) {
                            System.Console.WriteLine();
                            Console.WriteLine ((c + 1) + "° Produto: " + nome[c]);
                            Console.WriteLine ((c + 1) + "° Quantidade: " + quant[c]);
                            System.Console.WriteLine("--------------------------------");
                        }
                        break;

                    default:
                        //Nenhuma opção escolhida
                        System.Console.WriteLine();
                        Console.WriteLine ("----------------------------------------");
                        Console.WriteLine ("Obrigado pela preferencia! Volte sempre!");
                        Console.WriteLine ("----------------------------------------");
                        System.Console.WriteLine();
                        break;
                }
            }
        }
    }
}