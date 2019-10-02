using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class HomemFerroController{

        HomemFerroModel hom = new HomemFerroModel();

        public void Pular () {
            System.Console.WriteLine ("Homem de Ferro está pulando!");
        }

        public void ComArmadura () {
            hom.Armadura = true;
        }

        public void SemArmadura () {
            hom.Armadura = false;
        }

        public void Voar () {
            if (hom.Armadura == true) {
                System.Console.WriteLine ("Homem de Ferro voa com sua armadura!");
            } else {
                System.Console.WriteLine ("Homem de Ferro não possui sua armadura, Impossível voar");
            }
        }

        public void Atirar () {
            if (hom.Armadura == true) {
                System.Console.WriteLine ("Homem de Ferro atira com seu armadura!");
            } else {
                System.Console.WriteLine ("Homem de Ferro não possui sua armadura, Impossível atirar!");
            }
        }
    }
}