using System;
using Atividade_1.Controllers;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            PessoasController pessoa1 = new PessoasController ();
                pessoa1.CadastrarPessoa();
                pessoa1.ExibirPessoa();
        }
    }
}