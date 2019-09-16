using System;

namespace Aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos as notas que utilizaremos
            float nota1, nota2, nota3, media;
            // 
            string resultado;

            // Capturamos todas as notas respectivamente
            Console.WriteLine("Digite a sua primeira, segunda e terceira nota respectivamente: ");
            nota1 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());
            nota3 = float.Parse(Console.ReadLine());

            // Calculo da media
            media = (nota1+nota2+nota3)/3;

            // Condicional
            if(media >= 6){
                resultado = "Aprovado!";
            }
            else if(media < 6 && media >= 4){
                resultado = "de Recuperação";
            }
            else{
                resultado = "Reprovado!";
            }
            Console.WriteLine($"Sua condição no final deste ano letivo é: {resultado}, sua média foi de {media}.");
        }
    }
}
