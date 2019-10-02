using System;
using System.Collections.Generic;
using System.IO;
using Atividade_1.Models;

namespace Atividade_1 {
    class Program {
        
        static void Main (string[] args) {
            List<AlunoModel> cad = new List<AlunoModel> ();
            string sair = "rodando";
            while (sair != "2") {
                try {
                    System.Console.WriteLine ("Digite o seu Nome:");
                    string nome = Console.ReadLine ();
                    System.Console.WriteLine ("Digite o nome do seu Curso:");
                    string curso = Console.ReadLine ();
                    System.Console.WriteLine ("Digite sua Idade:");
                    int idade = int.Parse (Console.ReadLine ());
                    System.Console.WriteLine ("Digite seu RG:");
                    string rg = Console.ReadLine ();
                    System.Console.WriteLine ("Você é Bolsista? [TRUE / FALSE]");
                    bool bolsa = bool.Parse (Console.ReadLine ());
                    System.Console.Write("Você deseja continuar Cadastrando Alunos?\n[1 - SIM / 2 - NÃO]: ");
                    sair = Console.ReadLine();
                    
                    cad.Add (new AlunoModel (nome, curso, idade, rg, bolsa));

                } catch (Exception ex) {
                    System.Console.WriteLine ("Desculpe :( House um erro na aplicação");
                    SalvarErros (ex);
                }
            }

            foreach(AlunoModel i in cad){
                System.Console.WriteLine();
                System.Console.WriteLine(i.NomeAluno);
                System.Console.WriteLine(i.CursoAluno);
                System.Console.WriteLine(i.IdadeAluno);
                System.Console.WriteLine(i.RgAluno);
                System.Console.WriteLine(i.BolsistaAluno);
                System.Console.WriteLine("----------------------");
            }
        }

        private static void SalvarErros(Exception ex)
        {
            StreamWriter txt = new StreamWriter("Error_Log.txt", true);
            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();
        }


    }
}