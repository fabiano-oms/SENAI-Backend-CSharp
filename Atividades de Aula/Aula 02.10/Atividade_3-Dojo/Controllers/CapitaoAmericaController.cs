using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class CapitaoAmericaController {
        CapitaoAmericaModel cap = new CapitaoAmericaModel ();

        public void Pular () {
            System.Console.WriteLine ("Capitão América está pulando!");
        }

        public void ComEscudo () {
            cap.Escudo = true;
            // System.Console.WriteLine("Capitão América possui seu escudo");
        }

        public void SemEscudo () {
            cap.Escudo = false;
            // System.Console.WriteLine("Capitão América não possui seu escudo");
        }

        public void Lancar () {
            if (cap.Escudo == true) {
                System.Console.WriteLine ("Capitão América lança seu escudo!");
            } else {
                System.Console.WriteLine ("Capitão América não possui seu escudo, Impossível lança-lo");
            }
        }

        public void Defender () {
            if (cap.Escudo == true) {
                System.Console.WriteLine ("Capitão América defende-se com seu escudo!");
            } else {
                System.Console.WriteLine ("Capitão América não possui seu escudo, Impossível defender-se!");
            }
        }
    }
}