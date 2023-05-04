using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

        // public static Partida criarPartida(string nome, string senha) {
        //
        // }

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
