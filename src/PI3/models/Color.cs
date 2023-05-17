
namespace PI3.models{

    public class Color {
        public enum ColorEnum {
            Verde,
            Azul,
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
    }
}
