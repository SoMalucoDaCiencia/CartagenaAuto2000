using System.Collections.Generic;

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
            this.tipo = GetCardBitmap(tipo);
            this.quantidade = quantidade;
        }
        
        public static Bitmap GetCardBitmap(string tipo) {
            switch (tipo) {
                case "G": {
                    return TipoCartaEnum.Garrafa; break;
                }
                case "C":
                case "T": {// Tricornio
                    return TipoCartaEnum.Chapeu; break;
                }
                case "P": {
                    return TipoCartaEnum.Pistola; break;
                }
                case "B":
                case "E": {// Esqueleto(Jolly roger)
                    return TipoCartaEnum.Bandeira; break;
                }
                case "F": {
                    return TipoCartaEnum.Faca; break;
                }
                default: return null; break;
            }
        }

        public static List<Carta> CreateMao(string serverReponse)
        {
            List<Carta> ret = new List<Carta>();
            List<string> list = new List<string>(serverReponse.Replace("\r", "").Split('\n'));
            list.ForEach((str) => {
                var arr = str.Split(',');
                ret.Add(new Carta(arr[0], int.Parse(arr[0])));
            });
            return ret;
        }
    }
}
