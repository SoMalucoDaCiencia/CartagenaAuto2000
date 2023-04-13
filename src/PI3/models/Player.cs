
using System.Collections.Generic;
using System.Linq;

namespace PI3.models {

    public class Player{

        private long id { get; set; }

        private string nome { get; set; }

        private Color cor { get; set; }

        private string senha { get; set; }

        private List<Carta> mao { get; set; } = new List<Carta>();

        public Player(int id, string senha, Color cor) {
            this.id = id;
            this.senha = senha;
            this.cor = cor;
        }
        
        // Manda nome do jodador, id e senha da partida pro servidor, pega a resposta do servidor, cria player, adicionar na lista de players da partida e retorna o player criado
        public static Player CreatePlayerServer(string name, Partida partida) {
            var response = CartagenaServer.Jogo.EntrarPartida(partida.id, Utils.firstToUpper(name), partida.senha).Split(',');
            var pl =  new Player(int.Parse(response[0]), response[1], new Color(response[2]));
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
    }
}