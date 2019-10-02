using System;
using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers
{
    public class JogadoresController
    {
        JogadorModel player = new JogadorModel();
        CapitaoAmericaController player1 = new CapitaoAmericaController();
        HomemFerroController player2 = new HomemFerroController();

        public void EscolherJogador(){
            System.Console.WriteLine("Escolha o personagem:\n[1 - Capitão América]\n[2 - Homem de Ferro]");
            player.Operador = int.Parse(Console.ReadLine());

            // string ex = "funcionando";
            switch(player.Operador){
                case 1:
                    System.Console.Write("Capitão América possui seu escudo?\n[1 - SIM / 2 - NÃO]: ");
                    player.StatusEscudo = int.Parse(Console.ReadLine());
                    if(player.StatusEscudo == 1){
                        player1.ComEscudo();
                        System.Console.WriteLine("Escolha a ação a ser executada:\n[1 - Pular]\n[2 - Lançar]\n[3 - Defender]\n[4 - Status]");
                        player.Operador2 = int.Parse(Console.ReadLine());
                        switch(player.Operador2){
                            case 1:
                            break;
                            case 2:
                            break;
                            case 3:
                            break;
                            case 4:
                            break;
                        }
                    }
                    bool escudo = bool.Parse(Console.ReadLine());
                    if(escudo == true){
                        
                    }else{
                        player1.SemEscudo();
                    }
                break;
                case 2:

                break;
                default:
                    // ex = "erro";
                    System.Console.WriteLine("Personagem Inválido!");
                break;
            }
        }
    }
}