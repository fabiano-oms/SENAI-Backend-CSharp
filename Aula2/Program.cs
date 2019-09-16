using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos as notas que utilizaremos
            double nota1, nota2, nota3, media;

            // Capturamos todas as notas respectivamente
            Console.WriteLine("Digite a sua primeira, segunda e terceira nota respectivamente: ");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            // Calculamos a media
            media = ((nota1+nota2+nota3)/3);

            // Calculo do condicional
            if(media >= 6){
                Console.WriteLine("Aprovado!, média: "+media);
            } 
            else{
                Console.WriteLine($"Reprovado!, média: {media}, sua primeira nota foi {nota1}");
            }
        }
    }
}
