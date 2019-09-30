using System;
using System.Globalization;
using System.IO;
using Atividade_1.Models;

namespace Atividade_1.Controllers {
    public class PessoasController {
        PessoaModel persona = new PessoaModel ();

        public void CadastrarPessoa () {
            try {
                System.Console.WriteLine ("Digite seu Nome:");
                persona.NomePessoa = Console.ReadLine ();
                System.Console.WriteLine ("Digite sua Idade:");
                persona.IdadePessoa = int.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite seu Peso:");
                persona.PesoPessoa = float.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite sua Altura:");
                persona.AlturaPessoa = float.Parse (Console.ReadLine ());
            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe :( House um erro na aplicação");
                SalvarErros (ex);
            }
        }

        public void AtribuirImc (float Peso, float Altura) {
            float imc = Peso / (Altura * Altura);
            string formatarImc = string.Format("0:0.00}", imc);
            if (imc < 18.5f) {
                System.Console.WriteLine ($"Abaixo do peso, IMC: {formatarImc}");
            } else if (imc >= 18.5f && imc < 25f) {
                System.Console.WriteLine ($"Peso normal, IMC: {formatarImc}");
            } else if (imc >= 25f && imc < 30f) {
                System.Console.WriteLine ($"Sobrepeso, IMC: {formatarImc}");
            } else if (imc >= 30f && imc < 35f) {
                System.Console.WriteLine ($"Obesidade grau I, IMC: {formatarImc}");
            } else if (imc >= 35f && imc <= 39f) {
                System.Console.WriteLine ($"Obesidade grau II, IMC: {formatarImc}");
            } else {
                System.Console.WriteLine ($"Obesidade grau III, IMC: {formatarImc}");
            }
        }
        
        public void ExibirPessoa () {
            System.Console.WriteLine (persona.NomePessoa);
            System.Console.WriteLine (persona.IdadePessoa);
            System.Console.WriteLine (persona.PesoPessoa);
            System.Console.WriteLine (persona.AlturaPessoa);
            AtribuirImc (persona.PesoPessoa, persona.AlturaPessoa);
        }

        private void SalvarErros (Exception ex) {
            StreamWriter txt = new StreamWriter ("Error_Log.txt", true);
            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}