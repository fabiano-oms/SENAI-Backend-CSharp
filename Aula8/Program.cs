﻿using System;

namespace Aula8 {
    class Program {
        static void Main (string[] args) {
            string[] v1 = { "A", "B", "C" };

            //laço foreach (para nós "nó") estrutura de programação
            foreach (string letra in v1){
                Console.WriteLine (letra);
            }
        }
    }
}