using System;
using Atividade_4.Models;

namespace Atividade_4.Controllers {
    public class CalculadoraController {
        CalculadoraModel num = new CalculadoraModel ();

        public void Calculando(){
            System.Console.Write("Digite o 1º número: ");
            num.Num1Calc = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o 2º número: ");
            num.Num2Calc = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Escolha a operação:\n[ + - * / ]");
            num.Operador = Console.ReadLine();

            int ex = 0;
            switch (num.Operador)
            {
                case "+":
                    num.Resposta = Somar(num.Num1Calc,num.Num2Calc);
                break;

                case "-":
                    num.Resposta = Subtrair(num.Num1Calc,num.Num2Calc);
                break;

                case "*":
                    num.Resposta = Multiplicar(num.Num1Calc,num.Num2Calc);
                break;

                case "/":
                    num.Resposta = Dividir(num.Num1Calc,num.Num2Calc);
                break;


                default:
                    ex = 1;
                    System.Console.WriteLine("Operador desconhecido!");
                break;
            }

            if(ex == 0){
                System.Console.WriteLine($"O resultado da {num.Operador} de {num.Num1Calc} e {num.Num2Calc} é: {num.Resposta}");
            }
        }

        public double Somar (double n1, double n2) {
            return n1 + n2;
        }
        public double Subtrair (double n1, double n2) {
            return n1 - n2;
        }
        public double Multiplicar (double n1, double n2) {
            return n1 * n2;
        }
        public double Dividir (double n1, double n2) {
            return n1 / n2;
        }

    }
}