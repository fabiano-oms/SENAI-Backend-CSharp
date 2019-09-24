using System;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[10];
            float[] preco = new float[10];
            int op = 9;
            int p = 0;
            bool voltar = true;

            const int v = 10;
            const int w = 9;

            while (op != 0) {
                if (p < v) {
                    voltar = true;
                }

                Console.WriteLine (
                    @"MENU: 
                    1 - Cadastrar um produto que terá nome e um preço
                    2 - Listar todos os produto
                    3 - Calcular a soma de todos os preços dos produtos
                    
                    0 - Sair"
                );
                Console.Write ("Digite uma opção: ");
                op = int.Parse (Console.ReadLine ());

                switch (op) {
                    case 1:
                        //Cadastrar um produto que terá nome e um preço
                        if (p == v) {
                            Console.WriteLine ("Não é possivel cadastrar mais produtos.");
                        } else {
                            while (voltar == true) {
                                Console.Write ("Insira o nome do " + (p + 1) + "° produto: ");
                                nome[p] = Console.ReadLine ();

                                Console.Write ("Insira o valor do " + (p + 1) + "° produto: ");
                                preco[p] = float.Parse (Console.ReadLine ());

                                if (p <= w) {
                                    Console.WriteLine ("Gostaria de cadastrar outro produto? [true/false]");
                                    voltar = bool.Parse (Console.ReadLine ());
                                    p++;
                                }

                                if (p == v) {
                                    voltar = false;
                                    Console.WriteLine ("////////////////////////////");
                                    Console.WriteLine ("Não é possivel cadastrar mais produtos.");
                                }
                                Console.WriteLine ("////////////////////////////");
                            }
                        }
                    break;

                    case 2:
                        //Listar todos os produto
                        for (int c = 0; c <= (p - 1); c++) {
                            Console.WriteLine ((c + 1) + "° produto: " + nome[c]);
                            Console.WriteLine ((c + 1) + "° preço: " + preco[c]);
                            Console.WriteLine ("////////////////////////////");
                        }
                    break;

                    case 3:
                        //Calcular a soma de todos os preços dos produtos
                        float total = 0;
                        for (int c = 0; c <= p; c++) {
                            total = total + preco[c];
                        }
                        Console.WriteLine ("A soma total de todos os " + p + " produtos é: " + total);
                        Console.WriteLine ("////////////////////////////");
                    break;

                    default:
                        //Nenhuma opção escolhida
                        Console.WriteLine ("////////////////////////////");
                        Console.WriteLine ("Obrigado pela preferencia! Volte sempre!");
                    break;
                }
            }
        }
    }
}