using System;
using System.Collections.Generic;
using System.Linq;
using PI3.models;

namespace PI3{
    public class Engine{
        public static void process() {
            try {
                var tuple = myPiratesPosition();

                var loc1 = maisLongePossivel(tuple.Item1);
                GameCore.jogar(Program.partidaEstado, loc1.Item1, loc1.Item2);

                if (Program.partidaEstado.jogador.mao.Count >= 8) {
                    var loc2 = maisLongePossivel(tuple.Item2);
                    GameCore.jogar(Program.partidaEstado, loc2.Item1, loc2.Item2);

                    var loc3 = maisLongePossivel(tuple.Item3);
                    GameCore.jogar(Program.partidaEstado, loc3.Item1, loc3.Item2);
                }
                else if (Program.partidaEstado.jogador.mao.Count <= 3) {

                    var loc2 = maisLongePossivel(tuple.Item2);
                    if (hasGroups(loc2.Item1)) {
                        GameCore.voltar(Program.partidaEstado, loc2.Item1);
                    } else {
                        GameCore.pular(Program.partidaEstado);
                    }

                    var loc3 = maisLongePossivel(tuple.Item3);
                    if (hasGroups(loc3.Item1)) {
                        GameCore.voltar(Program.partidaEstado, loc3.Item1);
                    } else {
                        GameCore.pular(Program.partidaEstado);
                    }
                }
                else {

                    var loc2 = maisLongePossivel(tuple.Item2);
                    GameCore.jogar(Program.partidaEstado, loc2.Item1, loc2.Item2);

                    var loc3 = maisLongePossivel(tuple.Item3);
                    if (hasGroups(loc3.Item1)) {
                        GameCore.voltar(Program.partidaEstado, loc3.Item1);
                    } else {
                        GameCore.pular(Program.partidaEstado);
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
                       countPiratasCasa(casa.Key) == 1 ||
                       countPiratasCasa(casa.Key) == 2;
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
            return Program.partidaEstado.casas[posicao].piratasPresentes.Values.Aggregate((a, b) => a + b);
        }

        private static (int, int, int, int, int, int) myPiratesPosition() {
            var postions = Program.partidaEstado.casas.Keys.ToList()
                .FindAll((key) => key.Equals(Program.partidaEstado.jogador.id));
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
