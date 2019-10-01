using System;
using System.IO;
using Atividade_1.Models;

namespace Atividade_1.Controllers {
    public class AlunoController {
        AlunoModel aluno = new AlunoModel ();
        public void CadastrarAluno () {
            try {
                System.Console.WriteLine ("Digite o seu Nome:");
                aluno.NomeAluno = Console.ReadLine ();
                System.Console.WriteLine ("Digite o nome do seu Curso:");
                aluno.CursoAluno = Console.ReadLine ();
                System.Console.WriteLine ("Digite sua Idade:");
                aluno.IdadeAluno = int.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite seu RG:");
                aluno.RgAluno = Console.ReadLine ();
                System.Console.WriteLine ("Você é Bolsista? [TRUE / FALSE]");
                aluno.BolsistaAluno = bool.Parse (Console.ReadLine ());

            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe :( House um erro na aplicação");
                SalvarErros (ex);
            }
        }

        public void ExibirAluno(){
            System.Console.WriteLine(aluno.NomeAluno);
            System.Console.WriteLine(aluno.CursoAluno);
            System.Console.WriteLine(aluno.IdadeAluno);
            System.Console.WriteLine(aluno.RgAluno);
            System.Console.WriteLine(aluno.BolsistaAluno);
        }

        private void SalvarErros (Exception ex) {
            StreamWriter txt = new StreamWriter ("Error_Log.txt", true);
            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}