using System;

namespace Aula9 {
    class Program {
        static void Main (string[] args) {

            #region Aluno 1
            //Declarando o objeto
            //instanciando o objeto
            AlunoModel aluno = new AlunoModel(); 
            //Cadastrar o Aluno no sistema
            aluno.CadastrarAluno();
            //Exibir o Aluno no sistema
            aluno.ExibirAluno();
            #endregion
        }
    }
}