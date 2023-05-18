using System.Collections.Generic;

namespace PI3.models{
    public class Posicao{
        public TipoCartaEnum tipoPosicao { get; set; }

        public Dictionary<int, int> piratasPresentes { get; set; } = new Dictionary<int, int>();
        
        public Posicao(TipoCartaEnum tipo) {
            this.tipoPosicao = tipo;
        }
    }
}
