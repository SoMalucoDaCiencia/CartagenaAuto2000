using System;
using System.Collections.Generic;
using System.Linq;
using CartagenaServer;
using PI3.models;

namespace PI3{
    public class Partida{
        public int id { get; set; }

        public string name { get; set; }

        public string senha { get; set; }
        
        public Player jogador { get; set; }

        public int idJogadorAtual { get; set; }
        
        public int rodadaAtual { get; set; }

        public PartidaState.PartidaEnum state { get; set; }

        public Dictionary<int, Posicao> casas { get; set; }

        public List<JogadaAntiga> jogadasAntigas { get; set; }

        public DateTime createdAt { get; set; }

        public Partida(int idPartida, string nomeP, string senhaP) {
            this.id = idPartida;
            this.name = nomeP;
            this.senha = senhaP;
            this.state = PartidaState.parse(Jogo.VerificarVez(this.id).Substring(0, 1));
            this.createdAt = DateTime.Parse(new List<string>(Jogo.ListarPartidas("T").Replace("\r", "").Split('\n'))
                .FindAll((str) => str.StartsWith(this.id + ","))[0].Split(',')[2]);
            this.casas = new Dictionary<int, Posicao>();
        }

        public Partida() { }

        public Partida(int id, string name, DateTime createdAt, PartidaState.PartidaEnum state) {
            this.id = id;
            this.name = name;
            this.state = state;
            this.createdAt = createdAt;
        }

        //Retona uma lista com todos os nomes das partidas presentes na lista
        public static List<string> getPartidasNames(List<Partida> partidas) {
            return new List<string>(partidas.Select((p) => p.name));
        }
    }

    public class PartidaState{
        public enum PartidaEnum{
            ERRO,
            ABERTA,
            INICIADA,
            ENCERRADA
        }

        public static PartidaEnum parse(string str) {
            switch (str) {
                case "A": return PartidaEnum.ABERTA;
                case "J": return PartidaEnum.INICIADA;
                case "E": return PartidaEnum.ENCERRADA;
                default: return PartidaEnum.ERRO;
            }
        }

        public static string intoSring(PartidaEnum type) {
            switch (type) {
                case PartidaEnum.ABERTA: return "A";
                case PartidaEnum.INICIADA: return "J";
                case PartidaEnum.ENCERRADA: return "E";
                default: return "";
            }
        }
    }
}
