using System;

namespace Aula8_1 {
    class Program {
        static void Main (string[] args) {
            int numero;
            try{
                //Escreva um bloco de código
                Console.WriteLine ("Digite um número");
                numero = int.Parse (Console.ReadLine ());
                
            //tratamento para erros, "Ao invés de mostrar um código de erro mostra uma msg" 
            }catch(Exception ex){

                //Mostramos a exceção da regra
                //Erro gerado na aplicação
                Console.WriteLine($"Ops :( Deu RUIM, digite um número{ex}");
            }
        }
    }
}