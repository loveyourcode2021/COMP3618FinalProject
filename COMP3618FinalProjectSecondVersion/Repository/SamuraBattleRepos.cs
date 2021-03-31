using SamuraiBattle.Data;
using SamuraiBattle.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SamuraBattleRepos
    {
        private SamuraiBattleContext context;
        public SamuraBattleRepos()
        {
            context = new SamuraiBattleContext();
        }

        public ICollection<Samurai> GetSaumrais()
        {
            return context.Samurais.ToList();
        }

        public ICollection<Battle> GetBattles()
        {
            return context.Battles.ToList();
        }



        public void AddSamurai(Samurai samurai)
        {
            if (samurai != null)
            {
                Debug.WriteLine("working");
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }

        public void AddBattle(Battle battle)
        {
            if (battle != null)
            {
                Debug.WriteLine("working");
                context.Battles.Add(battle);
                context.SaveChanges();
            }
        }
        public void SeedSamuraiBattle(SamuraiBattleContext context)
        {
            if (!context.Samurais.Any())
            {
                var samurai = new List<Samurai>
                {
                    new Samurai {
                        Picture = "https://static.wikia.nocookie.net/l5r/images/0/0e/Samurai.jpg",
                        Name = "ASamurai",
                        Age = new Random().Next(0, 50),
                        Town = "Imaicho"
                    },
                    new Samurai {
                        Picture = "https://static.wikia.nocookie.net/l5r/images/0/0e/Samurai.jpg",
                        Name = "BSamurai",
                        Age = new Random().Next(0, 50),
                        Town = "Takium"
                    }
                };
                context.AddRange(samurai);
                context.SaveChanges();
            }

            if (!context.Battles.Any())
            {
                var battle = new List<Battle>
               {
                   new Battle{
                       FightDate = new DateTime(),
                       Name = "Last Samurai1",
                       Location = "Somewhere in Japan"
                   },
                   new Battle{
                       FightDate = new DateTime(),
                       Name = "Last Samurai2",
                       Location = "Somewhere in Japan"
                   }
               };

                context.AddRange(battle);
                context.SaveChanges();
            }
        }
    }
}
