using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Leader.Models
{
    public class LeaderContext : DbContext
    {
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Game> Games { get; set; }

        public LeaderContext() : base("LeaderContext")
        {}
   }
}