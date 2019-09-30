using System;
using Atividade_1.Models;

namespace Atividade_1.Controllers {
    public class PessoasController {
        PessoasModel persona = new PessoasModel ();

        public void CadastrarPessoa(){
            try{
                System.Console.WriteLine("Digite seu nome:");
                persona.NomePessoa = Console.ReadLine();
                //não terminou
            }catch{

            }
        }

    }
}