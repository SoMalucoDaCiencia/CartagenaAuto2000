using System.Linq;
using PI3.models;
using System;

namespace PI3{
    public class Engine{
        public static void process() {
            try {
                var tuple = myPiratesPosition();

                if (Program.partidaEstado.jogador.mao.Count >= 8 || isPrimeiraRodada()) {
                    if (Program.partidaEstado.rodadaAtual == 1) {
                        var loc1 = maisLongePossivel(tuple.Item1);
                        GameCore.jogar(Program.partidaEstado, tuple.Item1, loc1.Item2);
                    }

                    if (Program.partidaEstado.rodadaAtual == 2) {
                        var loc2 = maisLongePossivel(tuple.Item2);
                        GameCore.jogar(Program.partidaEstado, tuple.Item2, loc2.Item2);
                    }

                    if (Program.partidaEstado.rodadaAtual == 3) {
                        var loc3 = maisLongePossivel(tuple.Item3);
                        GameCore.jogar(Program.partidaEstado, tuple.Item3, loc3.Item2);
                    }
                }
                else if (Program.partidaEstado.jogador.mao.Count <= 3) {

                    if (Program.partidaEstado.rodadaAtual == 1) {
                        if (hasGroups(tuple.Item2)) {
                            GameCore.voltar(Program.partidaEstado, tuple.Item2);
                        }
                        else {
                            GameCore.pular(Program.partidaEstado);
                        }
                    }

                    if (Program.partidaEstado.rodadaAtual == 2) {
                        if (hasGroups(tuple.Item3)) {
                            GameCore.voltar(Program.partidaEstado, tuple.Item3);
                        }
                        else {
                            GameCore.pular(Program.partidaEstado);
                        }
                    }

                    if (Program.partidaEstado.rodadaAtual == 3) {
                        var loc1 = maisLongePossivel(tuple.Item1);
                        GameCore.jogar(Program.partidaEstado, tuple.Item1, loc1.Item2);
                    }
                }
                else {
                    if (Program.partidaEstado.rodadaAtual == 1) {
                        if (hasGroups(tuple.Item3)) {
                            GameCore.voltar(Program.partidaEstado, tuple.Item3);
                        }
                        else {
                            GameCore.pular(Program.partidaEstado);
                        }
                    }

                    if (Program.partidaEstado.rodadaAtual == 2) {
                        var loc1 = maisLongePossivel(tuple.Item1);
                        GameCore.jogar(Program.partidaEstado, tuple.Item1, loc1.Item2);
                    }

                    if (Program.partidaEstado.rodadaAtual == 3) {
                        var loc2 = maisLongePossivel(tuple.Item2);
                        GameCore.jogar(Program.partidaEstado, tuple.Item2, loc2.Item2);
                    }
                }
            } catch (Exception e) {
                GameCore.pular(Program.partidaEstado);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        private static (int, TipoCartaEnum) maisLongePossivel(int aPartirDe) {
            TipoCartaEnum tipoCasa = TipoCartaEnum.Nula;
            int maisLonge = (aPartirDe > 0 ? aPartirDe : myPiratesPosition().Item3);
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                int candidata = Program.partidaEstado.casas.ToList().FindAll((casa) => {
                    return countPiratasCasa(casa.Key) == 0 &&
                           casa.Key > aPartirDe &&
                           casa.Value.tipoPosicao == carta.tipo;
                }).Select(casa => casa.Key).ToList()[0];
                if (candidata > maisLonge) {
                    maisLonge = candidata;
                    tipoCasa = Program.partidaEstado.casas[candidata].tipoPosicao;
                }
            });
            return (maisLonge, tipoCasa);
        }

        private static bool hasGroups(int aPartirDe) {
            aPartirDe = (aPartirDe < 0 ? 0 : aPartirDe);
            var groups = Program.partidaEstado.casas.ToList().FindAll((casa) => {
                return (aPartirDe - casa.Key <= 7) &&
                       (countPiratasCasa(casa.Key) == 1 ||
                       countPiratasCasa(casa.Key) == 2) &&
                       casa.Key > 0;
            });
            return groups.Count > 0;
        }

        private static bool isAlcancavel(int posicaoPirata, int alvo) {
            // Ve se o número de jogadores no lugar alvo é 0
            return countPiratasCasa(alvo) == 0
                   &&
                   // Ve se o tipo no lugar alvo é disponivel no deck do jogador
                   Program.partidaEstado.jogador.mao.Select(one => one.tipo)
                       .Contains(Program.partidaEstado.casas[alvo].tipoPosicao)
                   &&
                   // Ve se n tem nenhuma outra casa entre o alvo e o pirata q é alcancavel com essa carta
                   Program.partidaEstado.casas.ToList().FindAll((one) => {
                       return one.Key < alvo &&
                              one.Key > posicaoPirata &&
                              one.Value.tipoPosicao == Program.partidaEstado.casas[alvo].tipoPosicao &&
                              countPiratasCasa(one.Key) == 0;
                   }).Count == 0;
        }

        private static int countPiratasCasa(int posicao) {
            if (Program.partidaEstado.casas[posicao].piratasPresentes == null || Program.partidaEstado.casas[posicao].piratasPresentes.Keys.ToList().Count <= 0) {
                return 0;
            }
            return Program.partidaEstado.casas[posicao].piratasPresentes.Values.Aggregate((a, b) => a + b);
        }

        private static bool isPrimeiraRodada() {
            return Program.partidaEstado.casas[0].piratasPresentes[Program.partidaEstado.jogador.id] > 3;
        }

        private static (int, int, int, int, int, int) myPiratesPosition() {
            var postions = Program.partidaEstado.casas.ToList().FindAll((one) => {
            return one.Value.piratasPresentes.ContainsKey(Program.partidaEstado.jogador.id) && one.Value.piratasPresentes[Program.partidaEstado.jogador.id] > 0;
        }).Select((casa) => casa.Key).ToList();
            postions.Sort();
            switch (postions.Count) {
                case 1:
                    return (postions[0], postions[0], postions[0], postions[0], postions[0], postions[0]);
                case 2:
                    return (postions[0], postions[1], postions[1], postions[1], postions[1], postions[1]);
                case 3:
                    return (postions[0], postions[1], postions[2], postions[2], postions[2], postions[2]);
                case 4:
                    return (postions[0], postions[1], postions[2], postions[3], postions[3], postions[3]);
                case 5:
                    return (postions[0], postions[1], postions[2], postions[3], postions[4], postions[4]);
                case 6:
                    return (postions[0], postions[1], postions[2], postions[3], postions[4], postions[5]);
                default: return (-1, -1, -1, -1, -1, -1);
            }
        }
    }
}
