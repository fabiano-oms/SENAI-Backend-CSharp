using System;
using Aula12_POO.Controllers;

namespace Aula12_POO {
    class Program {
        static void Main (string[] args) {
            CarrosController carro = new CarrosController();
            CarrosEletricosController carroEletrico = new CarrosEletricosController();

            Console.Clear(); //Limpa a tela do terminal
            carro.Ligar();
            carro.Acelerar();

            carro.CadastrarMotor();

            carroEletrico.CarregarBateria(15);
            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine($"Carga do carro: {carroEletrico.StatusBateria()}");
        }
    }
}