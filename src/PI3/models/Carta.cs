namespace PI3.models{
    
    public enum TipoCartaEnum{
        Chapeu,
        Pistola,
        Faca,
        Chave,
        Garrafa,
        Bandeira,
    }
    public class Carta{

        public TipoCartaEnum tipo { get; set; }

        public int quantidade { get; set; }

        public Carta(string tipo, int quantidade) {
            switch (tipo) {
                case "G": {
                    this.tipo = TipoCartaEnum.Garrafa; break;
                }
                case "T": {// Tricornio
                    this.tipo = TipoCartaEnum.Chapeu; break;
                }
                case "P": {
                    this.tipo = TipoCartaEnum.Pistola; break;
                }
                case "E": {// Esqueleto(Jolly roger)
                    this.tipo = TipoCartaEnum.Bandeira; break;
                }
                case "F": {
                    this.tipo = TipoCartaEnum.Faca; break;
                }
            }
            this.quantidade = quantidade;
        }
    }
}