namespace Aula11_POO.Models {
    public class ProdutosModel {

        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public FornecedoresModel Fornecedor { get; set; } //chamar um model dentro de outro model "herança" / (objeto)
    }
}