using System;
using System.Collections.Generic;
using CartagenaServer;
using PI3.models;

namespace PI3{
    public class GameCore{

        /// <summary>Lista partidas com o status especificado</summary>
        /// <param name="status"> Status das partidas </param>
        /// <returns></returns>
        public static List<Partida> listarPartidas(PartidaState.PartidaEnum status) {
            string serverResponse = Jogo.ListarPartidas(PartidaState.intoSring(status));
            Utils.checkError(serverResponse);

            List<Partida> ret = new List<Partida>();
            List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n'));
            list.ForEach((str) => {
                if (str != "") {
                    var arr = str.Split(',');
                    ret.Add(new Partida(int.Parse(arr[0]), arr[1], DateTime.Parse(arr[2]), PartidaState.parse(arr[3])));
                }
            });
            return ret;
        }

        /// <summary>Cria partida e retorna a instancia</summary>
        /// <param name="nome"> Nome da partida </param>
        /// <param name="senha"> Senha da partida </param>
        /// <returns></returns>
        public static Partida criarPartida(string nome, string senha) {
            Partida ret = new Partida();
            ret.id = int.Parse(Jogo.CriarPartida(nome, senha));
            ret.name = nome;
            ret.senha = senha;
            ret.state = PartidaState.parse(Jogo.VerificarVez(ret.id).Substring(0, 1));

            ret.players.AddRange(listarJogadores(ret.id));
            ret.createdAt = DateTime.Now;

            return ret;
        }

        /// <summary>Lista players presentes na partida</summary>
        /// <param name="idPartida"> Id da partida </param>
        /// <returns></returns>
        public static List<Player> listarJogadores(int idPartida) {
            string serverResponse = Jogo.ListarJogadores(idPartida);
            Utils.checkError(serverResponse);

            List<Player> ret = new List<Player>();
            List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n'));
            list.ForEach((str) => {
                if (str != "") {
                    var arr = str.Split(',');
                    ret.Add(new Player(int.Parse(arr[0]), arr[1], new Color(arr[2])));
                }
            });
            return ret;
        }

        // public static string entrarPartida(int idPartida, string nome, string senha) {
        // }
        //
        // public static string iniciarPartida(int idJogador, string senha) {
        // }
        //
        // public static List<Carta> consultarMao(int idJogador, string senha) {
        // }
    }
}
