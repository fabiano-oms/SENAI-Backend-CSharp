namespace Atividade_3_Dojo.Models {
    public class JogadorModel {
        //
        public int VidaJogador { get; set; } = 100;
        public string CorTextoJogador { get; set; }
        public string EquipeJogador { get; set; }

        //Capitao
        public bool Escudo { get; set; }

        //Homem ferro
        public bool Armadura { get; set; }

        //CONTAS
        public int Menu { get; set; } = 1;
        public int Menu2 { get; set; }
        public int StatusEscudo { get; set; }
        public int StatusArmadura { get; set; }
    }
}