using System.Linq;
using PI3.models;

namespace PI3{

    public class Engine{

        public static void process() {

            if (Program.partidaEstado.jogador.mao.Count <= 3) {

            } else if (Program.partidaEstado.jogador.mao.Count <= 8) {

            } else {
                var res = maisLongePossivel(myPiratesPosition().Item1);
                GameCore.jogar(Program.partidaEstado, res.Item1, res.Item2);
            }
        }

        private static (int, TipoCartaEnum) maisLongePossivel(int aPartirDe) {

            TipoCartaEnum tipoCasa = TipoCartaEnum.Nula;
            int maisLonge = (aPartirDe > 0 ? aPartirDe : 0);
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                Program.partidaEstado.casas.ToList().FindAll((casa) => isCasaAvaiable(casa.Key)).ForEach((casa) => {
                    if (casa.Value.tipoPosicao == carta.tipo && casa.Key > maisLonge) {
                        maisLonge = casa.Key;
                        tipoCasa = Program.partidaEstado.casas[casa.Key].tipoPosicao;
                    }
                });
            });
            return (maisLonge, tipoCasa);
        }

        private static bool isCasaAvaiable(int posicao) {
            return Program.partidaEstado.casas[posicao].piratasPresentes.Values.Aggregate((a, b) => a + b) < 3;
        }

        private static (int, int, int) myPiratesPosition() {
            var postions = Program.partidaEstado.casas.Keys.ToList().FindAll((key) => key.Equals(Program.partidaEstado.jogador.id));
            postions.Sort();
            switch (postions.Count) {
                case 1:
                    return (postions[0], postions[0], postions[0]);
                case 2:
                    return (postions[0], postions[1], postions[1]);
                case 3:
                    return (postions[0], postions[1], postions[2]);
                default: return (-1, -1, -1);
            }
        }
    }
}
