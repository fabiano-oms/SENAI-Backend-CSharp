using System;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {   
            string ex6_perm;
            Console.WriteLine("Digite sua idade:");
            int ex6_idade = int.Parse(Console.ReadLine());
            if(ex6_idade>=18){
                ex6_perm = "Todas";
            }else if(ex6_idade==17){
                ex6_perm = "Mature 17+";               
            }else if(ex6_idade<17 && ex6_idade>=13){
                ex6_perm = "Teen 13+";
            }else if(ex6_idade<13 && ex6_idade>=10){
                ex6_perm = "Everyone 10+";           
            }else{
                ex6_perm = "Everyone";
            }
            Console.WriteLine($"A classificação permitida é até: {ex6_perm}");
        }
    }
}
