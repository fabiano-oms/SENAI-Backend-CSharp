using Atividade_2.Models;

namespace Atividade_2.Controllers {
    public class CelularesController {
        CelularModel cel = new CelularModel();
        
        public void UsandoCelular(){
            LigarCelular(cel.ModeloCelular, cel.CorCelular, cel.TamanhoCelular);
            System.Console.WriteLine();
            FazerLigação();
            System.Console.WriteLine();
            EnviarMensagem();
            System.Console.WriteLine();
            DesligarCelular(cel.ModeloCelular, cel.CorCelular, cel.TamanhoCelular);
            System.Console.WriteLine();
        }

        public void LigarCelular(string modelo, string cor, string tam){
            cel.LigadoCelular = true;
            System.Console.WriteLine($"Ligando seu {modelo} {cor} com {tam}...");
        }

        public void DesligarCelular(string modelo, string cor, string tam){
            cel.LigadoCelular = false;
            System.Console.WriteLine($"Desligando seu {modelo} {cor} com {tam}...");
        }

        public void EnviarMensagem(){
            if(cel.LigadoCelular == true){
                System.Console.WriteLine("Enviando a Mensagem... \"sem conecção c\"... 3G de merda!");
            }else{
                System.Console.WriteLine("O celular está desligado! Impossível enviar uma mensagem");
            }
        }

        public void FazerLigação(){
            if(cel.LigadoCelular == true){
                System.Console.WriteLine("Fazendo a Ligação... \"Rede Indisponível\"... Sinal de merda!");
            }else{
                System.Console.WriteLine("O celular está desligado! Impossível fazer uma ligação");
            }
        }
    }
}