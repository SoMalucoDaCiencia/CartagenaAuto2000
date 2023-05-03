using CartagenaServer;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace PI3.models{
    public class Player{
        private int id { get; set; }

        private string nome { get; set; }

        private Color cor { get; set; }

        private string senha { get; set; }

        private List<Carta> mao { get; set; } = new List<Carta>();

        private List<Pirata> piratas { get; set; } = new List<Pirata>();

        //public

        public Player(int id, string nome, string senha, Color cor) {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.cor = cor;
            this.mao.AddRange(Carta.CreateMao(Jogo.ConsultarMao(this.id, this.senha)));
            //this.piratas.AddRange()
        }

        public Player(int id, string nome, Color cor) {
            this.id = id;
            this.nome = nome;
            this.senha = "";
            this.cor = cor;
            this.mao.AddRange(Carta.CreateMao(Jogo.ConsultarMao(this.id, this.senha)));
            //this.piratas.AddRange()
        }

        // Manda nome do jodador, id e senha da partida pro servidor, pega a resposta do servidor, cria player, adicionar na lista de players da partida e retorna o player criado
        public static Player CreatePlayerServer(string name, Partida partida) {
            var response = CartagenaServer.Jogo.EntrarPartida(partida.id, Utils.firstToUpper(name), partida.senha)
                .Split(',');
            var pl = new Player(int.Parse(response[0]), Utils.firstToUpper(name), response[1], new Color(response[2]));
            partida.players.Add(pl);
            return pl;
        }

        // Cria uma lista de players baseado na String retornada do servidor
        public static List<Player> CreatePlayers(string serverReponse) {
            List<Player> ret = new List<Player>();
            List<string> list = new List<string>(serverReponse.Split('\n'));
            list.ForEach((str) => {
                var arr = str.Split(',');
                ret.Add(new Player(int.Parse(arr[0]), arr[1], new Color(arr[2])));
            });
            return ret;
        }

        //Retona uma lista com todos os nomes dos jogadores presentes na lista
        public static List<string> GetPlayersNames(List<Player> players) {
            return new List<string>(players.Select((p) => p.nome));
        }

        public class PlayerState{
            public enum PlayerEnum{
                PRIMEIRA_JOGADA,
                SEGUNDA_JOGADA,
                TERCEIRA_JOGADA
            }

            public static PlayerEnum Parse(int str) {
                switch (str % 3) {
                    case 1: return PlayerEnum.PRIMEIRA_JOGADA;
                    case 2: return PlayerEnum.SEGUNDA_JOGADA;
                    case 3: return PlayerEnum.TERCEIRA_JOGADA;
                    default: return PlayerEnum.TERCEIRA_JOGADA;
                }
            }
        }
    }
}
