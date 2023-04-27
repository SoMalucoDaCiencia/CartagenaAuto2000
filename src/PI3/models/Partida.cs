
using System;
using System.Collections.Generic;
using System.Linq;
using CartagenaServer;
using PI3.models;

namespace PI3{
    
    public class Partida {
        
        public int id { get; set; }
        
        public string name { get; set; }
        
        public string senha { get; set; }

        public Player jogadorAtual { get; set; }



        public PartidaState.PartidaEnum state { get; set; }

        public Tabuleiro tabuleiro { get; set; }

        public List<Player> players { get; set; } = new List<Player>(); 

        public DateTime createdAt { get; set; }

        public static Partida CreatePartida(string nomeP, string senhaP)
        {
            Partida ret = new Partida();
            ret.id = int.Parse(Jogo.CriarPartida(nomeP, senhaP));
            ret.name = nomeP;
            ret.senha = senhaP; 
            ret.state = PartidaState.Parse(Jogo.VerificarVez(ret.id).Substring(0, 1));

            ret.players.AddRange(Player.CreatePlayers(Jogo.ListarJogadores(ret.id)));
            ret.createdAt = DateTime.Now;

            return ret;
        }

        public static Partida EnterPartida(int idPartida, string nomeP, string senhaP)
        {
            Partida ret = new Partida();
            ret.id = int.Parse(Jogo.EntrarPartida(idPartida, nomeP, senhaP));
            ret.name = nomeP;
            ret.senha = senhaP;
            ret.state = PartidaState.Parse(Jogo.VerificarVez(ret.id).Substring(0, 1));

            ret.players.AddRange(Player.CreatePlayers(Jogo.ListarJogadores(ret.id)));
            ret.createdAt = DateTime.Parse(new List<string>(Jogo.ListarPartidas("T").Replace("\r", "").Split('\n'))
                .FindAll((str) => str.StartsWith(ret.id + ","))[0].Split(',')[2]);

            return ret;
        }
    }

    public class PartidaState
    {
        public enum PartidaEnum {
            ERRO,
            ABERTA,
            INICIADA,
            ENCERRADA
        }

        public static PartidaEnum Parse(string str)
        {
            switch (str)
            {
                case "A": return PartidaEnum.ABERTA;
                case "J": return PartidaEnum.INICIADA;
                case "E": return PartidaEnum.ENCERRADA;
                default: return PartidaEnum.ERRO;
            }
        }
    }

}