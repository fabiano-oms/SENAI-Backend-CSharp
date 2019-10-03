namespace Atividade_3_Dojo.Models {
    public class JogadorModel {

        //Uso Geral
        public int VidaJogador { get; set; } = 100;
        public string EquipeJogador { get; set; }


        //Capitão América
        public bool Escudo { get; set; }
        public int StatusEscudo { get; set; }


        //Homem ferro
        public bool Armadura { get; set; }
        public int StatusArmadura { get; set; }


        //Menu
        public int Menu { get; set; } = 1;
        public int MenuCap { get; set; }
        public int MenuHom { get; set; }
    }
}