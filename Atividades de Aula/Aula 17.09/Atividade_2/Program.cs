using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex2_resp = "";
            float ex2_grav, ex2_calc;
            Console.Write("Digite seu Peso (N) no planeta Terra: ");
            float ex2_peso = float.Parse(Console.ReadLine());
            Console.WriteLine(
                "Digite o número do Planeta que você quer medir seu Peso: \n" +
                "1 - Mercúrio \n" +
                "2 - Vênus \n" +
                "3 - Marte \n" +
                "4 - Júpiter \n" +
                "5 - Saturno \n" +
                "6 - Urano"
            );
            int ex2_planeta = int.Parse(Console.ReadLine());
            switch(ex2_planeta){
                case 1:
                ex2_grav = 0.37f;
                ex2_resp = "O seu Peso em Mercúrio é: ";
                break;
                case 2:
                ex2_grav = 0.88f;
                ex2_resp = "O seu Peso em Vênus é: ";
                break;
                case 3:
                ex2_grav = 0.38f;
                ex2_resp = "O seu Peso em Marte é: ";
                break;
                case 4:
                ex2_grav = 2.64f;
                ex2_resp = "O seu Peso em Júpiter é: ";
                break;
                case 5:
                ex2_grav = 1.15f;
                ex2_resp = "O seu Peso em Saturno é: ";
                break;
                case 6:
                ex2_grav = 1.17f;
                ex2_resp = "O seu Peso em Urano é: ";
                break;
                default:
                ex2_grav = 0;
                ex2_resp = "O planeta não foi informado corretamente";
                break;
            }
            ex2_calc = ((ex2_peso/9.88f)*ex2_grav);
            Console.WriteLine(ex2_resp+ex2_calc+" N");
        }
    }
}
