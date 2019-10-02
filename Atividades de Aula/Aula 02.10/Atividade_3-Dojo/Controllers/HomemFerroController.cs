using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class HomemFerroController{

        JogadorModel hom = new JogadorModel();

        public void Pular () {
            System.Console.WriteLine ("\nHomem de Ferro está pulando!");
        }

        public void ComArmadura () {
            hom.Armadura = true;
            System.Console.WriteLine("\nHomem de Ferro está sincronizado com Jarvis!");
        }

        public void SemArmadura () {
            hom.Armadura = false;
            System.Console.WriteLine("\nUm péssimo dia para escolher terno!");
        }

        public void Voar () {
            if (hom.Armadura == true) {
                System.Console.WriteLine ("\nHomem de Ferro voa com sua armadura!");
            } else {
                System.Console.WriteLine ("\nHomem de Ferro não está usando sua armadura, Impossível voar!");
            }
        }

        public void Atirar () {
            if (hom.Armadura == true) {
                System.Console.WriteLine ("\nHomem de Ferro atira com seu armadura!");
            } else {
                System.Console.WriteLine ("\nHomem de Ferro não está usando sua armadura, Impossível atirar!");
            }
        }
    }
}