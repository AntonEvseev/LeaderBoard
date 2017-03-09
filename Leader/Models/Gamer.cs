using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leader.Models
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxScore { get; set; }
        public DateTime GamerDate { get; set; }

        public int? GameId { get; set; }
        public Game Game { get; set; }
    }
}