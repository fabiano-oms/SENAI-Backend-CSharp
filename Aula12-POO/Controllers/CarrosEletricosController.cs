using Aula12_POO.Models;

namespace Aula12_POO.Controllers {
    public class CarrosEletricosController : CarrosController {
        CarroEletricoModel carroEletrico = new CarroEletricoModel ();

        //Declarando objeto CarroEletricoModel
        MotorModel motor = new MotorModel ();

        public void CarregarBateria (float carga) {
            if (carroEletrico.Bateria < 100){
                carroEletrico.Bateria += carga;
            }else{
                System.Console.WriteLine("A bateria do carro já está completa! Pode viajar!");
            }
        }

        public float StatusBateria(){
            return carroEletrico.Bateria;
        }
    }
}