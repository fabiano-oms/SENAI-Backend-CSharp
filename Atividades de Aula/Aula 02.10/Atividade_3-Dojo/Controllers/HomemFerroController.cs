using System;
using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class HomemFerroController {

        JogadorModel hom = new JogadorModel ();

        public System.ConsoleColor Red () {
            return Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Pular () {
            System.Console.WriteLine ("\nHomem de Ferro está pulando!", Red ());
        }

        public void ComArmadura () {
            hom.Armadura = true;
            System.Console.WriteLine ("\nHomem de Ferro está sincronizado com Jarvis!", Red ());
        }

        public void SemArmadura () {
            hom.Armadura = false;
            System.Console.WriteLine ("\nUm péssimo dia para escolher terno!", Red ());
        }

        public void Voar () {
            if (hom.Armadura == true) {
                System.Console.WriteLine ("\nHomem de Ferro voa com sua armadura!", Red ());
            } else {
                System.Console.WriteLine ("\nHomem de Ferro não está usando sua armadura, Impossível voar!", Red ());
            }
        }

        public void Atirar () {
            if (hom.Armadura == true) {
                System.Console.WriteLine ("\nHomem de Ferro atira com seu armadura!", Red ());
            } else {
                System.Console.WriteLine ("\nHomem de Ferro não está usando sua armadura, Impossível atirar!", Red ());
            }
        }
    }
}