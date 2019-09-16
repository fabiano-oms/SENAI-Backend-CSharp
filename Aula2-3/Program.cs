using System;

namespace Aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deixamos declarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno;
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if(idade > 17){
                entrada = true;
            }
            if(entrada == true){
                retorno = "Entrada Permitida!!!";
            }
            else{
                retorno = "Entrada NÃO permitida!!!";
            }
            Console.WriteLine(retorno);
        }
    }
}
