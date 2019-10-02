namespace Atividade_1.Models {
    public class AlunoModel {
        public string NomeAluno { get; set; }
        public string CursoAluno { get; set; }
        public int IdadeAluno { get; set; }
        public string RgAluno { get; set; }
        public bool BolsistaAluno { get; set; }

        public AlunoModel (string nome, string curso, int idade, string rg, bool bolsa) {
            this.NomeAluno = nome;
            this.CursoAluno = curso;
            this.IdadeAluno = idade;
            this.RgAluno = rg;
            this.BolsistaAluno = bolsa;
        }
    }
}