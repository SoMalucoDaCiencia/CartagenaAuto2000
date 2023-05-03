
using System.Collections.Generic;

namespace PI3.models
{
    public class Posicao
    {
        public TipoCartaEnum tipoPosicao { get; set; }

        public List<Pirata> piratasPresentes { get; set; }
    }
}
