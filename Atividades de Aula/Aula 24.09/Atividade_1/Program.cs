using System;

namespace Atividade_1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite o CNPJ:");
            string cnpj = Console.ReadLine ();
            Console.WriteLine (ValidaCNPJ (cnpj));
        }
        static bool ValidaCNPJ (string cnpjuser) {
            bool resultado = false;
            int[] v1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string calculocnpj = "";
            string dig1 = "";
            string dig2 = "";
            int resto = 0;
            int calculo = 0;

            cnpjuser = cnpjuser.Replace (" ","");
            cnpjuser = cnpjuser.Replace ("-","");
            cnpjuser = cnpjuser.Replace (".","");
            cnpjuser = cnpjuser.Replace ("/","");

            calculocnpj = cnpjuser.Substring(0,12);

            for(int i=0; i<=11; i++){
                calculo += int.Parse (calculocnpj[i].ToString()) * v1[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if(resto < 2){
                dig1 = "0";
            }else{
                dig1 = calculo.ToString();
            }
            if(dig1 == cnpjuser[12].ToString()){
                resultado = true;
            }
            
            int[] v2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            resto = 0;
            calculocnpj += calculo.ToString();
            calculo = 0;

            for(int i=0; i<=12; i++){
                calculo += int.Parse (calculocnpj[i].ToString()) * v2[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if(resto < 2){
                dig2 = "0";
            }else{
                dig2 = calculo.ToString();
            }
            if(dig2 == cnpjuser[13].ToString()){
                resultado = true;
            }else{
                resultado = false;
            }

            return resultado;
        }
    }
}