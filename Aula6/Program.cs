using System;

namespace Aula6 {
    class Program {
        static void Main (string[] args) {

            // Chamamos nossa primeira função
            Console.WriteLine (BomDia ()); // se estiver vazio (1ª); se estiver com string (2ª); se estiver com números (3ª); 

            // Chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora (); // 4ª Função

            // Chamamos nossa função que calcula a média
            double[] numeros = { 2 , 5 , 2 , 8, 9 , 5 };
            Console.WriteLine( CalculaMedia(numeros) );

            // Chamamos nossa função de soma

            Console.WriteLine( CalculaSoma(numeros) );

        }

        // usar o /// para pode Descrever o Método (função)

        /// <summary>
        ///  1ª Função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>Olá! Bom Dia!</returns>
        static string BomDia () {
            return "Olá! Bom Dia!";
        }

        /// <summary>
        /// 2ª Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao"> um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horário</returns>
        static string BomDia (string saudacao) {
            int hora = DateTime.Now.Hour;
            if (hora >= 6 && hora <= 12) {
                saudacao = "Bom Dia!";
            } else if (hora > 12 && hora <= 18) {
                saudacao = "Boa Tarde!";
            } else {
                saudacao = "Boa Noite!";
            }
            return saudacao;
        }

        /// <summary>
        /// 3ª Função que retorna um número - teste de sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parâmetro</returns>
        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        /// 4ª Função retorna Data e Hora atuais
        /// </summary>
        static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour);
        }

        /// <summary>
        /// 5ª Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado = resultado + valores[i];
                //soma += valores[i] também funciona como acumulador
            }
            resultado = resultado / valores.Length;
            return resultado;
        }
        static double CalculaSoma (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }
            return resultado;
        }
    }
}