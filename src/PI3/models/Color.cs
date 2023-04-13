
namespace PI3.models{

    public enum ColorEnum {
        Verde,
        Azul,
        Vermelho,
        Amarelo,
        Marrom
    }
    
    public class Color{
        
        private ColorEnum value { get; set; }
        
        public Color(string color) {
            switch (color) {
                case "Verde": {
                    this.value = ColorEnum.Verde; break;
                }
                case "Azul": {
                    this.value = ColorEnum.Azul; break;
                }
                case "Vermelho": {
                    this.value = ColorEnum.Vermelho; break;
                }
                case "Amarelo": {
                    this.value = ColorEnum.Amarelo; break;
                }
                case "Marrom": {
                    this.value = ColorEnum.Marrom; break;
                }
            }
        }
    }
}