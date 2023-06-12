using System.Linq;
using PI3.models;
using System;
using System.Collections.Generic;

namespace PI3{
    public class Engine{
        private static (int, int, int, int, int, int) tuple = myPiratesPosition();
        public static void process() {
            try {
                var counter = Program.partidaEstado.jogador.mao.Select((one) => one.quantidade).Aggregate((a, b) => a + b);
                if (Program.partidaEstado.jogador.mao.Select((one) => one.quantidade).Aggregate((a, b) => a + b) >= 8 || isPrimeiraRodada()) {
                    if (Program.partidaEstado.rodadaAtual == 1) {
                        avancar(tuple.Item1);
                    }

                    if (Program.partidaEstado.rodadaAtual == 2) {
                        avancar(tuple.Item2);
                    }

                    if (Program.partidaEstado.rodadaAtual == 3) {
                        avancar(tuple.Item3);
                    }
                }
                else if (Program.partidaEstado.jogador.mao.Select((one) => one.quantidade).Aggregate((a, b) => a + b) <= 3) {

                    if (Program.partidaEstado.rodadaAtual == 1) {
                        voltar(tuple);
                    }

                    if (Program.partidaEstado.rodadaAtual == 2) {
                        voltar(tuple);
                    }

                    if (Program.partidaEstado.rodadaAtual == 3) {
                        avancar(tuple.Item3);
                    }
                }
                else {
                    if (Program.partidaEstado.rodadaAtual == 1) {
                        voltar(tuple);
                    }

                    if (Program.partidaEstado.rodadaAtual == 2) {
                        avancar(tuple.Item2);
                    }

                    if (Program.partidaEstado.rodadaAtual == 3) {
                        avancar(tuple.Item3);
                    }
                }
            } catch (Exception e) {
                GameCore.pular(Program.partidaEstado);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        private static void avancar(int pos) {
            var loc1 = maisLongePossivel(pos);
            if(loc1.Item1 == 37)
            {
                loc1.Item2 = getLastTipoEnumCarta(loc1.Item1);
            }
            if (loc1.Item1 > 0 && loc1.Item2 != TipoCartaEnum.Nula) { 
            GameCore.jogar(Program.partidaEstado, pos, loc1.Item2);
            tuple = myPiratesPosition();
            }
        }

        private static void voltar((int, int, int, int, int, int) tp) {
            int target = 0;
            bool avancou = false;
            if (hasGroups(tp.Item5)) {
                target = tp.Item5;
            } else {
                if (hasGroups(tp.Item4)) {
                    target = tp.Item4;
                } else {
                    if (hasGroups(tp.Item3)) {
                        target = tp.Item3;
                    } else {
                        if (hasGroups(tp.Item6)) {
                            target = tp.Item6;
                        } else {
                            avancar(tp.Item1);
                            avancou = true;
                        }
                    }
                }
            }
            if (!avancou)
            {
                GameCore.voltar(Program.partidaEstado, target);
                tuple = myPiratesPosition();
            }   
        }


        private static (int, TipoCartaEnum) maisLongePossivel(int aPartirDe) {
            TipoCartaEnum tipoCasa = TipoCartaEnum.Nula;
            int maisLonge = ( - 1);
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                List<int> candidatas = Program.partidaEstado.casas.ToList().FindAll((casa) => {
                    return (countPiratasCasa(casa.Key) == 0 &&
                           casa.Key > aPartirDe &&
                           casa.Value.tipoPosicao == carta.tipo) || casa.Key == 37;
                }).Select(casa => casa.Key).ToList();
                if(candidatas == null)
                {
                    Console.WriteLine("s");
                }
                int candidata = candidatas[0];
                if (candidata > maisLonge) {
                    maisLonge = candidata;
                    tipoCasa = Program.partidaEstado.casas[candidata].tipoPosicao;
                }
            });
            return (maisLonge, tipoCasa);
        }

        private static bool hasGroups(int aPartirDe) {
            if (aPartirDe <= 1) {
                return false;
            }
            var groups = Program.partidaEstado.casas.ToList().FindAll((casa) => casa.Key > 1 && casa.Key < aPartirDe).ToList().FindAll((casa) => {
                return (aPartirDe - casa.Key <= 7 && aPartirDe - casa.Key > 0) &&
                       (countPiratasCasa(casa.Key) == 1 ||
                        countPiratasCasa(casa.Key) == 2);
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
            return Program.partidaEstado.casas[0].piratasPresentes.ContainsKey(Program.partidaEstado.jogador.id) && Program.partidaEstado.casas[0].piratasPresentes[Program.partidaEstado.jogador.id] > 3;
        }

        private static TipoCartaEnum getLastTipoEnumCarta(int aPartirDe)
        {
            TipoCartaEnum ret = TipoCartaEnum.Nula;
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                List<int> aFrente = Program.partidaEstado.casas.ToList()
                    .FindAll((casa) => casa.Key > aPartirDe && casa.Key < 37)
                    .Select((casa) => (int)casa.Value.tipoPosicao).ToList();
                if (!aFrente.Contains((int)carta.tipo))
                {
                    ret = carta.tipo;
                }
            });
            return ret;
        }

        private static (int, int, int, int, int, int) myPiratesPosition() {
            var postions = new List<int>();
            Program.partidaEstado.casas.ToList().FindAll((one) => {
                return one.Value.piratasPresentes.ContainsKey(Program.partidaEstado.jogador.id) && one.Value.piratasPresentes[Program.partidaEstado.jogador.id] > 0;
            }).ToList().ForEach((one) => {
                for (int o = 0; o < one.Value.piratasPresentes[Program.partidaEstado.jogador.id]; o++)
                {
                    postions.Add(one.Key);
                }
            });
            postions.Sort();
            switch (postions.Count) {
                case 1:
                    return (postions[0], postions[0], postions[0], postions[0], postions[0], postions[0]);
                case 2:
                    return (postions[0], postions[0], postions[0], postions[0], postions[0], postions[1]);
                case 3:
                    return (postions[0], postions[0], postions[0], postions[0], postions[1], postions[2]);
                case 4:
                    return (postions[0], postions[0], postions[0], postions[1], postions[2], postions[3]);
                case 5:
                    return (postions[0], postions[0], postions[1], postions[2], postions[3], postions[4]);
                case 6:
                    return (postions[0], postions[1], postions[2], postions[3], postions[4], postions[5]);
                default: return (-1, -1, -1, -1, -1, -1);
            }
        }
    }
}
