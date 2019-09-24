using System;

namespace Modificado {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data_voo = new string[5];
            int p = 0;
            bool voltar = true;

            int op = 5;

            while (op != 0) {
                if (p < 5) {
                    voltar = true;
                }

                Console.WriteLine (
                    "\n 1 - Cadastrar Passagem \n " +
                    "2 - Listar Passagens \n " +
                    "0 - Sair \n" +
                    "------------------\n" +
                    "------------------\n"
                );
                Console.Write ("Digite uma opção: ");
                op = int.Parse (Console.ReadLine ());

                switch (op) {
                    case 1:
                        //Cadastrar Passagem
                        if (p == 5) {
                            Console.WriteLine ("Não é possivel cadastrar mais passageiros.");
                        } else {
                            while (voltar == true) {
                                Console.Write ("Digite o nome do " + (p + 1) + "° passageiro: ");
                                nome[p] = Console.ReadLine ();

                                Console.Write ("Digite a origem do " + (p + 1) + "° passageiro: ");
                                origem[p] = Console.ReadLine ();

                                Console.Write ("Digite o destino do " + (p + 1) + "° passageiro: ");
                                destino[p] = Console.ReadLine ();

                                Console.Write ("Digite o data do voo do " + (p + 1) + "° passageiro: ");
                                data_voo[p] = Console.ReadLine ();

                                if (p <= 4) {
                                    Console.WriteLine ("Gostaria de cadastrar outro passageiro? [true/false]");
                                    voltar = bool.Parse (Console.ReadLine ());
                                    p++;
                                }

                                if (p == 5) {
                                    voltar = false;
                                    Console.WriteLine ("Não é possivel cadastrar mais passageiros.");
                                }

                                Console.WriteLine ("////////////////////////////");
                                Console.WriteLine ("////////////////////////////");
                            }
                        }
                        break;

                    case 2:
                        //Listar Passagens
                        for (int c = 0; c < p; c++) {
                            Console.WriteLine ("O nome do " + (c + 1) + "° passageiro: " + nome[c]);
                            Console.WriteLine ("A origem do " + (c + 1) + "° passageiro: " + origem[c]);
                            Console.WriteLine ("O destino do " + (c + 1) + "° passageiro: " + destino[c]);
                            Console.WriteLine ("O data do voo do " + (c + 1) + "° passageiro: " + data_voo[c]);
                            Console.WriteLine ("////////////////////////////");
                            Console.WriteLine ("////////////////////////////");
                        }
                        break;

                    default:
                        Console.WriteLine ("////////////////////////////");
                        Console.WriteLine ("////////////////////////////");
                        Console.WriteLine ("Obrigado pela preferencia! Volte sempre!");
                        break;
                }
            }
        }
    }
}