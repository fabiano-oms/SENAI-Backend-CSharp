﻿using System;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            try{
            System.Console.Write ("Digite o valor: ");
            double valor = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite a porcentagem: ");
            double porcentagem = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ($"O valor com desconto de {porcentagem}% é: {CalculaDesconto(valor,porcentagem)}");
            }catch(Exception){
                System.Console.WriteLine("Ops deu RUIM!!, Digite somente números!!");
            }
        }

        static double CalculaDesconto (double valor, double porcentagem) {
            double resultado = 0;
            resultado = valor - (valor * (porcentagem / 100));
            return resultado;
        }
    }
}