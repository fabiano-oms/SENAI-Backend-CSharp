usign System;

namespace Aula9.Models {
    public class AlunoModel {

        //atributos

        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome { get; set; }

        /// <summary>
        /// Nome do Curso
        /// </summary>
        /// <value>string</value>
        public string Curso { get; set; }

        /// <summary>
        /// Número do RA
        /// </summary>
        /// <value>RA</value>
        public string RA { get; set; }

        /// <summary>
        /// Idade
        /// </summary>
        /// <value>Idade</value>
        public int Idade { get; set; }

        //comportamentos

        /// <summary>
        /// Começar a estudar
        /// </summary>
        public void Estudar(){
            System.Console.WriteLine("Estou estudando"!);
        }

        /// <summary>
        /// Pedir café para o professor
        /// </summary>
        public void PedirIntervalo(){
            System.Console.WriteLine("Pode fazer intervalo aeeee!");
            System.Console.WriteLine("QUERO CAFÉÉÉ!!");
        }

        /// <summary>
        /// Pede ajuda
        /// </summary>
        public void PedirAjuda(){
            System.Console.WriteLine("O Paulo, chega ae!!");
        }

        public void CadastrarAluno(){
            System.Console.WriteLine("Insira o seu nome:");
            aluno.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira o nome do Curso:");
            aluno.Curso = Console.ReadLine();
            
            System.Console.WriteLine("Insira seu RA:");
            aluno.RA = Console.ReadLine();
            
            System.Console.WriteLine("Insira sua idade:");
            aluno.Idade = int.Parse(Console.ReadLine());
        }

        public void ExibirAluno(){
            System.Console.WriteLine($"Nome: {aluno.Nome}");
            System.Console.WriteLine($"Curso: {aluno.Curso}");
            System.Console.WriteLine($"RA: {aluno.RA}");
            System.Console.WriteLine($"Idade: {aluno.Idade}");
        }
    }
}