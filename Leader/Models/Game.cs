using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leader.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Gamer> Gamers { get; set; }
        public Game()
        {
            Gamers = new List<Gamer>();
        }
    }
}