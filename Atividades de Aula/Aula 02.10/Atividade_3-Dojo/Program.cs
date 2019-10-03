using System;
using Atividade_3_Dojo.Controllers;

namespace Atividade_3_Dojo {
    class Program {
        static void Main (string[] args) {
        JogadoresController jogar = new JogadoresController();
            jogar.IniciarJogo();
        }
    }
}