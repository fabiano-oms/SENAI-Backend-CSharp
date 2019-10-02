using System;
using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class JogadoresController {
        JogadorModel player = new JogadorModel ();
        CapitaoAmericaController player1 = new CapitaoAmericaController ();
        HomemFerroController player2 = new HomemFerroController ();

        public void IniciarJogo () {
            Console.Clear ();
            while (player.Menu != 0) {
                player.MenuCap = 1;
                player.MenuHom = 1;
                EscolherPersonagemMenu ();
                switch (player.Menu) {
                    case 0:
                        System.Console.WriteLine (
                            @"
                                                    ---------------------
                                                     Obrigado por Jogar!
                                                    ---------------------"
                        );
                        System.Console.WriteLine();
                        break;
                    case 1:
                        Escudo ();
                        if (player.StatusEscudo == 1) {
                            player1.ComEscudo ();
                            while (player.MenuCap != 0) {
                                MenuCapitaoAmerica ();
                            }
                        } else {
                            player1.SemEscudo ();
                            while (player.MenuCap != 0) {
                                MenuCapitaoAmerica ();
                            }
                        }
                        break;
                    case 2:
                        Armadura ();
                        if (player.StatusArmadura == 1) {
                            player2.ComArmadura ();
                            while (player.MenuHom != 0) {
                                MenuHomemFerro ();
                            }
                        } else {
                            player2.SemArmadura ();
                            while (player.MenuHom != 0) {
                                MenuHomemFerro ();
                            }
                        }
                        break;
                    default:
                        System.Console.WriteLine ("\nPersonagem Inválido!");
                        System.Console.WriteLine();
                        break;
                }
            }
        }

        public void EscolherPersonagemMenu () {
            System.Console.WriteLine (
                @"
                                                    Escolha o Personagem:
                                                    [1 - Capitão América]
                                                    [2 - Homem de Ferro ]

                                                    [0 - Sair           ]"
            );
            System.Console.Write ("\nINPUT: ");
            player.Menu = int.Parse (Console.ReadLine ());
        }

        public void Escudo () {
            System.Console.WriteLine (
                            @"
                                                    Capitão América possui seu Escudo?
                                                    [1 - SIM]
                                                    [2 - NÃO]"
            );
            System.Console.Write ("\nINPUT: ");
            player.StatusEscudo = int.Parse (Console.ReadLine ());
        }
        
        public void MenuCapitaoAmerica () {
            System.Console.WriteLine (
                @"
                                                    Escolha a ação a ser executada:
                                                    [1 - Pular   ]
                                                    [2 - Lançar  ]
                                                    [3 - Defender]
                                                    [4 - Status  ]
                                                    [0 - Voltar  ]"
            );
            System.Console.Write ("\nINPUT: ");
            player.MenuCap = int.Parse (Console.ReadLine ());
            switch (player.MenuCap) {
                case 0:
                    System.Console.WriteLine ("\nReiniciando o Jogo!");
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
                    // player.Status ();
                    break;
                default:
                    System.Console.WriteLine ("\nAção Inválida!");
                    break;
            }
        }

        public void Armadura () {
            System.Console.WriteLine (
                            @"
                                                    Homem de Ferro está com sua Armadura?
                                                    [1 - SIM]
                                                    [2 - NÃO]"
            );
            System.Console.Write ("\nINPUT: ");
            player.StatusArmadura = int.Parse (Console.ReadLine ());
        }

        public void MenuHomemFerro () {
            System.Console.WriteLine (
                @"
                                                    Escolha a ação a ser executada:
                                                    [1 - Pular   ]
                                                    [2 - Atirar  ]
                                                    [3 - Voar    ]
                                                    [4 - Status  ]
                                                    [0 - Voltar  ]"
            );
            System.Console.Write ("\nINPUT: ");
            player.MenuHom = int.Parse (Console.ReadLine ());
            switch (player.MenuHom) {
                case 0:
                    System.Console.WriteLine ("\nReiniciando o Jogo!");
                    break;
                case 1:
                    player2.Pular ();
                    break;
                case 2:
                    player2.Atirar ();
                    break;
                case 3:
                    player2.Voar ();
                    break;
                case 4:
                    // player.Status ();
                    break;
                default:
                    System.Console.WriteLine ("\nAção Inválida!");
                    break;
            }
        }
    }
}