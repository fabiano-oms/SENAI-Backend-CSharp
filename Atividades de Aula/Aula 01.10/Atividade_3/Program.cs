using System;
using Atividade_3.Controllers;

namespace Atividade_3 {
    class Program {
        static void Main (string[] args) {
            ProdutosController reserva1 = new ProdutosController();
            Console.Clear();
                reserva1.ListarReserva();
        }
    }
}