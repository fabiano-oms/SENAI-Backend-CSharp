using System;

namespace Aula1 //COMENTARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somente declaramos, sem atribuir valor
            int num1;

            // Somente atribuimos um valor
            int num2 = 5;

            // Declaramos diversas variáveis do mesmo tipo
            int num3, num4, num5;

            // Variável do tipo decimal (real)
            float media;

            // Variável do tipo lógico (booleana)
            bool resultado = false;

            // Variável do tipo texto (caracteres)
            string nomeAluno;

            // dotnet build: vizualiza se tem erro
            // dotnet run: inicia o código


            // Escreve no terminal na mesma linha, porém quebra linha no próximo código
            Console.WriteLine("Bem vindos à nossa primeira aplicação:");
            // ("Bem vindos à nossa primeira aplicação:" + num2 + "" + num3);

            // Escreve no terminal na mesma linha, mantendo o próximo nela
            Console.Write("Digite o seu nome: ");
            
            // Captura o dado utilizado pelo usuário e salva na variável
            nomeAluno = Console.ReadLine();

            // Concatenação: Juntar uma informação (Um texto informativo "+" um valor)
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota: ");

            // Converto o texto capturado para o tipo inteiro (Parse que faz a conversão)
            num3 = int.Parse(Console.ReadLine());
            // Interpolação usa o "$"
            Console.WriteLine($"Sua primeira nota é {num3}");

            // Finalização do Exercicio
            Console.WriteLine("Digite sua segunda nota: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3+num4+num5)/3;
            Console.WriteLine("Sua Média é: " + media);

        }
    }
}
