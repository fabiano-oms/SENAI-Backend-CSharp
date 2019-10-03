using System;
using Atividade_3_Dojo.Models;

namespace Atividade_3_Dojo.Controllers {
    public class CapitaoAmericaController {
        JogadorModel cap = new JogadorModel ();

        public System.ConsoleColor Blue () {
            return Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void Pular () {
            System.Console.WriteLine ("\nCapitão América está pulando!", Blue ());
        }

        public void ComEscudo () {
            cap.Escudo = true;
            System.Console.WriteLine ("\nCapitão América equipou seu escudo!", Blue ());
        }

        public void SemEscudo () {
            cap.Escudo = false;
            System.Console.WriteLine ("\nCapitão América esqueceu seu escudo no banheiro!", Blue ());
        }

        public void Lancar () {
            if (cap.Escudo == true) {
                System.Console.WriteLine ("\nCapitão América lança seu escudo!", Blue ());
            } else {
                System.Console.WriteLine ("\nCapitão América não possui seu escudo, Impossível lança-lo!", Blue ());
            }
        }

        public void Defender () {
            if (cap.Escudo == true) {
                System.Console.WriteLine ("\nCapitão América defende-se com seu escudo!", Blue ());
            } else {
                System.Console.WriteLine ("\nCapitão América não possui seu escudo, Impossível defender-se!", Blue ());
            }
        }
    }
}