using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class CapitaoAmericaController {
        CapitaoAmericaModel cap = new CapitaoAmericaModel ();

        public void Pular () {
            System.Console.WriteLine ("\nCapitão América está pulando!");
        }

        public void ComEscudo () {
            cap.Escudo = true;
            System.Console.WriteLine("\nCapitão América equipou seu escudo!");
        }

        public void SemEscudo () {
            cap.Escudo = false;
            System.Console.WriteLine("\nCapitão América esqueceu seu escudo no banheiro!");
        }

        public void Lancar () {
            if (cap.Escudo == true) {
                System.Console.WriteLine ("\nCapitão América lança seu escudo!");
            } else {
                System.Console.WriteLine ("\nCapitão América não possui seu escudo, Impossível lança-lo");
            }
        }

        public void Defender () {
            if (cap.Escudo == true) {
                System.Console.WriteLine ("\nCapitão América defende-se com seu escudo!");
            } else {
                System.Console.WriteLine ("\nCapitão América não possui seu escudo, Impossível defender-se!");
            }
        }
    }
}