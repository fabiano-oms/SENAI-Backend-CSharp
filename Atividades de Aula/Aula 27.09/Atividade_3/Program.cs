using System;

namespace Atividade_3 {
    class Program {
        static void Main (string[] args) {
            string teste = "";
            System.Console.WriteLine ("1 - Razão Social\n2 - Nome e Sobrenome\n3 - Idade, Peso e Altura");
            teste = Console.ReadLine ();
            if (teste == "1") {
                System.Console.WriteLine (MostraInfo ());
            } else if (teste == "2") {
                System.Console.WriteLine (MostraInfo ("Fabiano", "Oliveira"));
            } else if (teste == "3") {
                System.Console.WriteLine (MostraInfo (20, 62.5F, 1.75F));
            } else {
                System.Console.WriteLine ("Opção Inválida");
            }
        }

        static string MostraInfo () {
            return "SERVICO NACIONAL DE APRENDIZAGEM INDUSTRIAL - SENAI";
        }

        static string MostraInfo (string nome, string sobrenome) {
            return $"O seu nome é: {nome} {sobrenome}";
        }

        static string MostraInfo (int idade, float peso, float altura) {
            return $"Sua idade é: {idade.ToString()} anos\nSeu peso é: {peso.ToString()} KG\nSua altura é: {altura.ToString()} m";
        }
    }
}