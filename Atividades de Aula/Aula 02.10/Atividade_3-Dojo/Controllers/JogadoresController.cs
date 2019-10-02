using System;
using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers
{
    public class JogadoresController
    {
        JogadorModel player = new JogadorModel();
        CapitaoAmericaController player1 = new CapitaoAmericaController();
        HomemFerroController player2 = new HomemFerroController();

        public void IniciarJogo(){
            Console.Clear();
            while(player.Menu != 0){
                player.Menu2 = 1;
                System.Console.WriteLine(
                                                    @"
                                                    Escolha o Personagem:
                                                    [1 - Capitão América]
                                                    [2 - Homem de Ferro ]

                                                    [0 - Sair           ]"
                );
                System.Console.Write("\nINPUT: ");
                player.Menu = int.Parse(Console.ReadLine());

                switch(player.Menu){
                    case 0:
                        System.Console.WriteLine(
                                                    @"
                                                    -------------------
                                                    Obrigado por Jogar!
                                                    -------------------"
                        );
                    break;
                    case 1:
                        System.Console.WriteLine(
                                                    @"
                                                    Capitão América possui seu escudo?
                                                    [1 - SIM]
                                                    [2 - NÃO]"
                        );
                        System.Console.Write("\nINPUT: ");
                        player.StatusEscudo = int.Parse(Console.ReadLine());
                        if(player.StatusEscudo == 1){
                            player1.ComEscudo();
                            while (player.Menu2 != 0){
                                MenuCapitaoAmerica();
                            }
                        }else{
                            player1.SemEscudo();
                            while (player.Menu2 != 0){
                                MenuCapitaoAmerica();
                            }
                        }
                    break;
                    case 2:

                    break;
                    default:
                        System.Console.WriteLine("Personagem Inválido!");
                    break;
                }
            }
        }

        public void Status (){

        }

        public void MenuCapitaoAmerica(){
            System.Console.WriteLine(
                                                    @"
                                                    Escolha a ação a ser executada:
                                                    [1 - Pular   ]
                                                    [2 - Lançar  ]
                                                    [3 - Defender]
                                                    [4 - Status  ]
                                                    [0 - Voltar  ]"
            );
            System.Console.Write("\nINPUT: ");
            player.Menu2 = int.Parse(Console.ReadLine());
            switch(player.Menu2){
                case 0:
                    System.Console.WriteLine("\nReiniciando o Jogo!");
                break;
                case 1:
                    player1.Pular ();
                break;
                case 2:
                    player1.Lancar ();
                break;
                case 3:
                    player1.Defender ();
                break;
                case 4:
                    // player1.Status ();
                break;
                default:
                    System.Console.WriteLine("\nAção Inválida!");
                break;
            }
        }

        public void Personagem
    }
}