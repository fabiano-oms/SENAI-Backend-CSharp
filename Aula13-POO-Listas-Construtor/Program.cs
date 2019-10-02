using System;
using System.Collections.Generic;
using Aula13_POO_Listas_Construtor.Models;

namespace Aula13_POO_Listas_Construtor {
    class Program {
        static void Main (string[] args) {
            //-------------1
            //Instanciando o ProdutoModel
            ProdutoModel produto = new ProdutoModel (1, "Maça", "Verde", 3.5);

            //Chamamos um atributo do objeto instanciado
            System.Console.WriteLine (produto.NomeProduto);
            //-------------1

            //-------------2
            //Instanciamos nossa classe
            //Sem passar parâmetros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel ();

            //Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;
            //-------------2

            //-------------3
            //Chamamos a nossa lista que vai ser do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel> ();

            //Adicionamos objetos instanciados e atribuídos em nossa lista
            prod.Add (new ProdutoModel (1, "Cenoura", "Cor Laranja", 2.30));
            prod.Add (new ProdutoModel (1, "Mamão", "Cor Laranja", 2.30));
            prod.Add (new ProdutoModel (1, "Beterraba", "Cor Laranja", 2.30));
            prod.Add (new ProdutoModel (1, "Pastel", "Cor Laranja", 2.30));
            prod.Add (new ProdutoModel (1, "Caldo de Cana", "Cor Laranja", 2.30));
            prod.Add (new ProdutoModel (1, "Chuchu", "Cor Laranja", 2.30));

            //Fazemos a varredura "Lemos" dos dados da nossa lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine();
                System.Console.WriteLine(p.IdProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }
            //------------3

            //------------4
            System.Console.WriteLine(prod[4]);
            //------------4
        }
    }
}