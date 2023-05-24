
using System.Drawing;

namespace PI3.models{

    public class Color {
        public enum ColorEnum {
            Azul,
            Verde,
            Vermelho,
            Amarelo,
            Marrom,
            NULL
        }

        public static ColorEnum Parse(string str) {
            switch (str) {
                case "Verde": {
                    return ColorEnum.Verde;
                }
                case "Azul": {
                    return ColorEnum.Azul;
                }
                case "Vermelho": {
                    return ColorEnum.Vermelho;
                }
                case "Amarelo": {
                    return ColorEnum.Amarelo;
                }
                case "Marrom": {
                    return ColorEnum.Marrom;
                }
                default: return ColorEnum.NULL;
            }
        }

        public static Bitmap getPirate(ColorEnum color) {
            switch (color) {
                case ColorEnum.Azul: return Properties.Resources.pirataAzul; break;
                case ColorEnum.Verde: return Properties.Resources.pirataVerde; break;
                case ColorEnum.Vermelho: return Properties.Resources.pirataVermelho; break;
                case ColorEnum.Amarelo: return Properties.Resources.pirataAmarelo; break;
                case ColorEnum.Marrom: return Properties.Resources.pirataMarrom; break;
                default: return null; break;
            }
        }
    }
}
