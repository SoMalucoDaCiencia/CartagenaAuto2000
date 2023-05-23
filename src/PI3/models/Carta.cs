using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using PI3.Properties;

namespace PI3.models{

    public enum TipoCartaEnum{
        Tricornio,
        Pistola,
        Faca,
        Chave,
        Garrafa,
        Esqueleto,
        Nula
    }

    public class Carta{

        public TipoCartaEnum tipo { get; set; }

        public int quantidade { get; set; }

        public Carta(string tipo, int quantidade) {
            this.tipo = GetTipoCartaEnum(tipo);
            this.quantidade = quantidade;
        }

        public Carta(string tipo) {
            this.tipo = GetTipoCartaEnum(tipo);
            this.quantidade = 0;
        }

        public static TipoCartaEnum GetTipoCartaEnum(string tipo) {
            switch (tipo) {
                case "G": {
                    return TipoCartaEnum.Garrafa; break;
                }
                case "T": {// Tricornio
                    return TipoCartaEnum.Tricornio; break;
                }
                case "P": {
                    return TipoCartaEnum.Pistola; break;
                }
                case "E": {// Esqueleto(Jolly roger)
                    return TipoCartaEnum.Esqueleto; break;
                }
                case "F": {
                    return TipoCartaEnum.Faca; break;
                }
                case "C": {
                    return TipoCartaEnum.Chave; break;
                }
                default: return TipoCartaEnum.Nula; break;
            }
        }

        public static Bitmap GetCardBitmap(TipoCartaEnum tipo, bool simbolo) {
            var letter = tipo.ToString().ToArray()[0];
            switch (letter) {
                case 'G': {
                    return (simbolo ? Properties.Resources.garrafa1 : Properties.Resources.Garrafa); break;
                }
                case 'T': {// Tricornio
                    return (simbolo ? Properties.Resources.tricornio1 : Properties.Resources.Tricornio); break;
                }
                case 'P': {
                    return (simbolo ? Properties.Resources.pistola1 : Properties.Resources.Pistola); break;
                }
                case 'E': {
                    return (simbolo ? Properties.Resources.esqueleto1 : Properties.Resources.Esqueleto); break;
                }
                case 'F': {
                    return (simbolo ? Properties.Resources.faca1 : Properties.Resources.Faca); break;
                }
                case 'C': {
                    return (simbolo ? Properties.Resources.chave1 : Properties.Resources.Chave); break;
                }
                default: return null; break;
            }
        }
    }
}
