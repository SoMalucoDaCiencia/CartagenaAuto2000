using System;
using System.Collections.Generic;
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
                ret.players.AddRange(listarJogadores(ret.id));
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
                return new Player(int.Parse(list[0]), list[1], Color.Parse(list[2]));
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
        public static Dictionaty<int, Posicao> extractTabuleiro(int idPartida) {
            try {
            	// Return obj Dictionaty<idPosition{0~36}, Position>
                Dictionaty<int, Posicao> ret = new Dictionaty<int, Posicao>();

                // Fill list of positions instances ======

                string serverResponse = Jogo.VerificarTabuleiro(idPartida);
                Utils.checkError(serverResponse);
                
                serverResponse.Replace("\r", "").Split("\n").forEach((casa) => {
                    ret.Add(int.Parse(casa.Split(",")[0]), new Posicao(Carta.GetTipoCartaEnum(casa.Split(",")[1])));
                })

                // Set pirates on it's positions ======

                serverResponse = Jogo.VerificarVez(idPartida);
                Utils.checkError(serverResponse);
                
                string[] processedResponse = serverResponse.Replace("\r", "").Split("\n")
                for (int f=1; f<processedResponse.Length; f++) {
                	string[] infCasa = processedResponse[f].Split(',')
                	if(!ret[int.Parse(infCasa[0])].piratasPresentes.ContainsKey(int.Parse(infCasa[1]))) {
                		ret[int.Parse(infCasa[0])].piratasPresentes.Add(int.Parse(infCasa[1]), int.Parse(infCasa[2]))
                	} else {
                		ret[int.Parse(infCasa[0])].piratasPresentes[int.Parse(infCasa[1])] = int.Parse(infCasa[2]))
                	}
                }
                return ret;

            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Player iniciarPartida(Partida partida) {
            try {
                if (partida.players.Count > 0) {
                    string serverResponse = Jogo.IniciarPartida(partida.players[0].id, partida.players[0].senha);
                    Utils.checkError(serverResponse);

                    partida.idJogadorAtual = int.Parse(serverResponse);
                    Player player = partida.players.Find((p) => p.id == partida.idJogadorAtual);
                    if (player!=null) {
                        return player;
                    } else {
                        MessageBox.Show("N foi possível achar o jogador que inicia a partida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                } else {
                    MessageBox.Show("Partdia com jogadores vazios", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //
        // public static List<Carta> consultarMao(int idJogador, string senha) {
        // }
    }
}









