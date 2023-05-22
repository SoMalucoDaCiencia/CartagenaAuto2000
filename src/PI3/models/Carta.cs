using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using PI3.Properties;

namespace PI3.models{

    public enum TipoCartaEnum{
        Tricornio,
        Revolver,
        Faca,
        Chave,
        Garrafa,
        Esqueleto,
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
                case "R": {
                    return TipoCartaEnum.Revolver; break;
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
                default: return TipoCartaEnum.Faca; break;
            }
        }

        public static Bitmap GetCardBitmap(TipoCartaEnum tipo, bool simbolo) {
            switch (tipo.ToString().ToArray()[0]) {
                case 'G': {
                    return (simbolo ? Properties.Resources.garrafa1 : Properties.Resources.Garrafa); break;
                }
                case 'T': {// Tricornio
                    return (simbolo ? Properties.Resources.tricornio1 : Properties.Resources.Tricornio); break;
                }
                case 'R': {
                    return (simbolo ? Properties.Resources.revolver1 : Properties.Resources.Revolver); break;
                }
                case 'E': {
                    return (simbolo ? Properties.Resources.caveira : Properties.Resources.Esqueleto); break;
                }
                case 'F': {// Esqueleto(Jolly roger)
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
