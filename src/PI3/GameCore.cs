using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CartagenaServer;
using PI3.models;

namespace PI3{
    public class GameCore{
        /// <summary>Lista partidas com o status especificado</summary>
        /// <param name="status"> Status das partidas </param>
        /// <returns></returns>
        public static List<Partida> listarPartidas(PartidaState.PartidaEnum status) {
            try {
                string serverResponse = Jogo.ListarPartidas(PartidaState.intoSring(status));
                Utils.checkError(serverResponse);

                List<Partida> ret = new List<Partida>();
                List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n'));
                list.ForEach((str) => {
                    if (str != "") {
                        var arr = str.Split(',');
                        ret.Add(new Partida(int.Parse(arr[0]), arr[1], DateTime.Parse(arr[2]),
                            PartidaState.parse(arr[3])));
                    }
                });
                return ret;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>Cria partida e retorna a instancia</summary>
        /// <param name="nome"> Nome da partida </param>
        /// <param name="senha"> Senha da partida </param>
        /// <returns></returns>
        public static Partida criarPartida(string nome, string senha) {
            try {
                string serverResponse = Jogo.CriarPartida(nome, senha);
                Utils.checkError(serverResponse);

                Partida ret = new Partida();
                ret.id = int.Parse(serverResponse);
                ret.name = nome;
                ret.senha = senha;
                ret.state = PartidaState.parse(Jogo.VerificarVez(ret.id).Substring(0, 1));
                ret.createdAt = DateTime.Now;
                return ret;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>Lista players presentes na partida</summary>
        /// <param name="idPartida"> Id da partida </param>
        /// <returns></returns>
        public static List<Player> listarJogadores(int idPartida) {
            try {
                string serverResponse = Jogo.ListarJogadores(idPartida);
                Utils.checkError(serverResponse);

                List<Player> ret = new List<Player>();
                List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n'));
                list.ForEach((str) => {
                    if (str != "") {
                        var arr = str.Split(',');
                        ret.Add(new Player(int.Parse(arr[0]), arr[1], Color.Parse(arr[2])));
                    }
                });
                return ret;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>Cria um jogador e entra em uma partida</summary>
        /// <param name="idPartida">Id da partida</param>
        /// <param name="nome">Nome do Jogador</param>
        /// <param name="senha">Senha da Partida</param>
        /// <returns>Id do jogador criado, senha gerada, cor atribuída</returns>
        public static Player entrarPartida(int idPartida, string nome, string senha) {
            try {
                string serverResponse = Jogo.EntrarPartida(idPartida, nome, senha);
                Utils.checkError(serverResponse);

                List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n')[0].Split(','));
                return new Player(int.Parse(list[0]), nome, list[1], Color.Parse(list[2]));
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }


        // <summary>Cria um jogador e entra em uma partida</summary>
        /// <param name="idPartida">Id da partida</param>
        /// <returns> Posicoes jogador </returns>
        public static void update(Partida partida) {
            try {
                Dictionary<int, Posicao> ret = new Dictionary<int, Posicao>();

                // Fill list of positions instances ======
                if (partida.state == PartidaState.PartidaEnum.INICIADA) {

                    string serverResponse = Jogo.ExibirTabuleiro(partida.id);
                    Utils.checkError(serverResponse);

                    serverResponse.Replace("\r", "").Split('\n').ToList().ForEach((casa) => {
                        ret.Add(int.Parse(casa.Split(',')[0]), new Posicao(Carta.GetTipoCartaEnum(casa.Split(',')[1])));
                    });

                    // Set pirates on it's positions ======

                    serverResponse = Jogo.VerificarVez(partida.id);
                    Utils.checkError(serverResponse);

                    string[] processedResponse = serverResponse.Replace("\r", "").Split(',');
                    for (int f=1; f<processedResponse.Length; f++) {
                        string[] infCasa = processedResponse[f].Split(',');
                        if(!ret[int.Parse(infCasa[0])].piratasPresentes.ContainsKey(int.Parse(infCasa[1]))) {
                            ret[int.Parse(infCasa[0])].piratasPresentes.Add(int.Parse(infCasa[1]), int.Parse(infCasa[2]));
                        } else {
                            ret[int.Parse(infCasa[0])].piratasPresentes[int.Parse(infCasa[1])] = int.Parse(infCasa[2]);
                        }
                    }

                    string[] infPartida = processedResponse[0].Split(',');
                    partida.state = PartidaState.parse(infPartida[0]);
                    partida.idJogadorAtual = int.Parse(infPartida[1]);
                    partida.rodadaAtual = int.Parse(infPartida[2]);
                    partida.casas = ret;
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string getPlayerName(int idPartida, int idJogador) {
            return Utils.firstToUpper(listarJogadores(idPartida).Find((one) => one.id == idJogador).nome);
        }

        public static void iniciarPartida(Partida partida) {
            try {
                string serverResponse = Jogo.IniciarPartida(partida.jogador.id, partida.jogador.senha);
                Utils.checkError(serverResponse);

                partida.idJogadorAtual = int.Parse(serverResponse);
                update(partida);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void jogar(Partida partida, int indexPosicao, Carta carta) {
            try {
                if (partida.state == PartidaState.PartidaEnum.INICIADA) {
                    string serverResponse = Jogo.Jogar(partida.jogador.id, partida.jogador.senha, indexPosicao, carta.ToString().ToArray()[0].ToString());
                    Utils.checkError(serverResponse);

                    partida.idJogadorAtual = int.Parse(serverResponse);
                    update(partida);
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Carta> consultarMao(Partida partida) {
            try {
                string serverResponse = Jogo.ConsultarMao(partida.jogador.id, partida.jogador.senha);
                Utils.checkError(serverResponse);

                List<Carta> ret = new List<Carta>();
                List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n'));
                list.ForEach((str) => {
                    var arr = str.Split(',');
                    ret.Add(new Carta(arr[0], int.Parse(arr[0])));
                });

                update(partida);
                return ret;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}









