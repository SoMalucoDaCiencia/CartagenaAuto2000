
using System;
using System.Collections.Generic;
using PI3.models;

namespace PI3{
    
    public class Partida {
        
        public int id { get; set; }
        
        public string name { get; set; }
        
        public string senha { get; set; }

        public int state { get; set; }

        public Tabuleiro tabuleiro { get; set; }

        public List<Player> players { get; set; } = new List<Player>(); 

        public DateTime createdAt { get; set; }
    }
}