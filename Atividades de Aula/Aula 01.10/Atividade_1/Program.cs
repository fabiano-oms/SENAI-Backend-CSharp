using System;
using Atividade_1.Controllers;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            AlunoController aluno1 = new AlunoController(); //instanciar
            Console.Clear();
                aluno1.CadastrarAluno(); //Comentar para auto preencher
                System.Console.WriteLine("---------------------");
                aluno1.ExibirAluno();
        }
    }
}