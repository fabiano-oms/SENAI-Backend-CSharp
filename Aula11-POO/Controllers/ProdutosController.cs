using System;
using System.IO;
using Aula11_POO.Models;

namespace Aula11_POO.Controllers {
    public class ProdutosController {
        ProdutosModel produto = new ProdutosModel ();

        public void CadastrarProduto () {
            try {
                System.Console.WriteLine ("Digite o ID do produto:");
                produto.IdProduto = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite o Nome do Produto:");
                produto.NomeProduto = Console.ReadLine ();

                System.Console.WriteLine ("Digite a Descrição do Produto:");
                produto.Descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o Preço do Produto:");
                produto.Preco = double.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o ID do Fornecedor:");
                // produto.Fornecedor.IdFornecedor = int.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o Nome do Fornecedor:");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine ();
            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe :( House um erro na aplicação");
                SalvarErros (ex);
            }
        }

        public void ExibirProduto () {
            System.Console.WriteLine (produto.IdProduto);
            System.Console.WriteLine (produto.NomeProduto);
            System.Console.WriteLine (produto.Descricao);
            System.Console.WriteLine (produto.Preco);

            // System.Console.WriteLine (produto.Fornecedor.IdFornecedor);
            // System.Console.WriteLine (produto.Fornecedor.NomeFornecedor);
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