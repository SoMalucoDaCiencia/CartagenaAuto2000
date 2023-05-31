using System.Collections.Generic;
using System.Linq;
using PI3.models;

namespace PI3{

    public class Engine{

        public static void process() {

            var tuple = myPiratesPosition();
            // if (Program.partidaEstado.jogador.mao.Count <= 3) {
            //
            // } else
            if (Program.partidaEstado.jogador.mao.Count <= 8)
            {
                findGroups().ForEach((one) => {
                    if (one > tuple.Item1 && isAlcancavel(tuple.Item1, one)) {
                        GameCore.jogar(Program.partidaEstado, tuple.Item1, Program.partidaEstado.casas[one].tipoPosicao);
                    } else if (one > tuple.Item2 && isAlcancavel(tuple.Item2, one)) {
                        GameCore.jogar(Program.partidaEstado, tuple.Item2, Program.partidaEstado.casas[one].tipoPosicao);
                    } else if (one > tuple.Item2 && isAlcancavel(tuple.Item3, one)) {
                        GameCore.jogar(Program.partidaEstado, tuple.Item3, Program.partidaEstado.casas[one].tipoPosicao);
                    } else {

                    }
                });
            } else {
                var res = maisLongePossivel(tuple.Item1);
                GameCore.jogar(Program.partidaEstado, res.Item1, res.Item2);
            }
        }

        private static (int, TipoCartaEnum) maisLongePossivel(int aPartirDe) {

            TipoCartaEnum tipoCasa = TipoCartaEnum.Nula;
            int maisLonge = (aPartirDe > 0 ? aPartirDe : myPiratesPosition().Item3);
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                Program.partidaEstado.casas.ToList().FindAll((casa) => countCasa(casa.Key) < 3).ForEach((casa) => {
                    if (casa.Value.tipoPosicao == carta.tipo && casa.Key > maisLonge) {
                        maisLonge = casa.Key;
                        tipoCasa = Program.partidaEstado.casas[casa.Key].tipoPosicao;
                    }
                });
            });
            return (maisLonge, tipoCasa);
        }

        private static List<int> findGroups() {
            var tuple = myPiratesPosition();
            var casasJogaveis = Program.partidaEstado.casas.ToList().FindAll((casa) => {
                return Program.partidaEstado.jogador.mao.Select((one) => one.tipo).Contains(casa.Value.tipoPosicao) &&
                       (countCasa(casa.Key) <= 2) &&
                       (countCasa(casa.Key) > 0) &&
                       casa.Key > tuple.Item1;
            });
            return casasJogaveis.Select(one => one.Key).ToList();
        }

        private static bool isAlcancavel(int posicaoPirata, int alvo) {
            if (Program.partidaEstado.jogador.mao.Select(one => one.tipo).Contains(Program.partidaEstado.casas[alvo].tipoPosicao)) {
                if (Program.partidaEstado.casas.ToList().FindAll((one) =>
                    {
                        return (one.Key < alvo && one.Key > posicaoPirata) && countCasa(one.Key) < 3 &&
                               one.Value.tipoPosicao == Program.partidaEstado.casas[alvo].tipoPosicao;
                    }).Count <= 0) {
                    return true;
                }
                return false;
            }

            return false;
        }

        private static int countCasa(int posicao) {
            return Program.partidaEstado.casas[posicao].piratasPresentes.Values.Aggregate((a, b) => a + b);
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
