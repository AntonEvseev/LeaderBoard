using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Leader.Models
{
    public class LeaderDbInitializer : DropCreateDatabaseAlways<LeaderContext>
    {
        protected override void Seed(LeaderContext context)
        {
            Gamer g1 = new Gamer { Name = "Carson", MaxScore = 2345, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g2 = new Gamer { Name = "Meredith", MaxScore = 1345, GamerDate = DateTime.Parse("2017-02-09") };
            Gamer g3 = new Gamer { Name = "Arturo", MaxScore = 3454, GamerDate = DateTime.Parse("2017-03-02") };
            Gamer g4 = new Gamer { Name = "Gytis", MaxScore = 1000, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g5 = new Gamer { Name = "Yan", MaxScore = 222, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g6 = new Gamer { Name = "Peggy", MaxScore = 4567, GamerDate = DateTime.Parse("2017-03-01") };
            Gamer g7 = new Gamer { Name = "Laura", MaxScore = 100, GamerDate = DateTime.Parse("2017-03-05") };
            Gamer g8 = new Gamer { Name = "Nino", MaxScore = 4567, GamerDate = DateTime.Parse("2017-03-02") };
            Gamer g9 = new Gamer { Name = "Cool", MaxScore = 4567, GamerDate = DateTime.Parse("2017-03-07") };
            Gamer g10 = new Gamer { Name = "Byt", MaxScore = 3443, GamerDate = DateTime.Parse("2017-03-06") };
            Gamer g11 = new Gamer { Name = "Storm", MaxScore = 1234, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g12 = new Gamer { Name = "Dino", MaxScore = 3445, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g13 = new Gamer { Name = "Mops", MaxScore = 766, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g14 = new Gamer { Name = "Cream", MaxScore = 345, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g15 = new Gamer { Name = "Fly", MaxScore = 2345, GamerDate = DateTime.Parse("2017-03-04") };
            Gamer g16 = new Gamer { Name = "Bich", MaxScore = 111, GamerDate = DateTime.Parse("2017-03-05") };
            Gamer g17 = new Gamer { Name = "Fuck", MaxScore = 453267, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g18 = new Gamer { Name = "Luck", MaxScore = 657, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g19 = new Gamer { Name = "Micky", MaxScore = 3453, GamerDate = DateTime.Parse("2017-02-09") };
            Gamer g20 = new Gamer { Name = "Valik", MaxScore = 4567, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g21 = new Gamer { Name = "Anton", MaxScore = 452267, GamerDate = DateTime.Parse("2017-02-09") };
            Gamer g22 = new Gamer { Name = "Max", MaxScore = 2424234, GamerDate = DateTime.Parse("2017-02-09") };
            Gamer g23 = new Gamer { Name = "Fox", MaxScore = 456447, GamerDate = DateTime.Parse("2017-03-01") };
            Gamer g24 = new Gamer { Name = "Win", MaxScore = 3, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g25 = new Gamer { Name = "Black", MaxScore = 34, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g26 = new Gamer { Name = "Jack", MaxScore = 343, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g27 = new Gamer { Name = "Rembo", MaxScore = 411567, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g28 = new Gamer { Name = "Terminator", MaxScore = 6757, GamerDate = DateTime.Parse("2017-03-05") };
            Gamer g29 = new Gamer { Name = "Hollywood", MaxScore = 35, GamerDate = DateTime.Parse("2017-03-04") };
            Gamer g30 = new Gamer { Name = "100p", MaxScore = 2334, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g31 = new Gamer { Name = "Dedpool", MaxScore = 45234267, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g32 = new Gamer { Name = "Maus", MaxScore = 45367, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g33 = new Gamer { Name = "Ttt", MaxScore = 4533267, GamerDate = DateTime.Parse("2017-03-09") };
            Gamer g34 = new Gamer { Name = "Dynamyt", MaxScore = 555, GamerDate = DateTime.Parse("2017-03-06") };
            Gamer g35 = new Gamer { Name = "Vino", MaxScore = 777, GamerDate = DateTime.Parse("2017-03-08") };
            
            context.Gamers.Add(g1);
            context.Gamers.Add(g2);
            context.Gamers.Add(g3);
            context.Gamers.Add(g4);
            context.Gamers.Add(g5);
            context.Gamers.Add(g6);
            context.Gamers.Add(g7);
            context.Gamers.Add(g8);
            context.Gamers.Add(g9);
            context.Gamers.Add(g10);
            context.Gamers.Add(g11);
            context.Gamers.Add(g12);
            context.Gamers.Add(g13);
            context.Gamers.Add(g14);
            context.Gamers.Add(g15);
            context.Gamers.Add(g16);
            context.Gamers.Add(g17);
            context.Gamers.Add(g18);
            context.Gamers.Add(g19);
            context.Gamers.Add(g20);
            context.Gamers.Add(g21);
            context.Gamers.Add(g22);
            context.Gamers.Add(g23);
            context.Gamers.Add(g24);
            context.Gamers.Add(g25);
            context.Gamers.Add(g26);
            context.Gamers.Add(g27);
            context.Gamers.Add(g28);
            context.Gamers.Add(g29);
            context.Gamers.Add(g30);
            context.Gamers.Add(g31);
            context.Gamers.Add(g32);
            context.Gamers.Add(g33);
            context.Gamers.Add(g34);
            context.Gamers.Add(g35);

            Game ga1 = new Game
            {
                Id = 1,
                Name = "World of Tanks",
                Gamers = new List<Gamer>() { g1, g2, g3, g4, g5, g6, g7, g8, g9, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23 }
            };
            Game ga2 = new Game
            {
                Id = 2,
                Name = "Counter Strike",
                Gamers = new List<Gamer>() { g28, g27, g26, g25, g24 }
            };
            Game ga3 = new Game
            {
                Id = 3,
                Name = "Super Mario",
                Gamers = new List<Gamer>() { g35, g34, g31, g33, g29, g32, g30 }
            };

            context.Games.Add(ga1);
            context.Games.Add(ga2);
            context.Games.Add(ga3);

            base.Seed(context);
        }
    }
}