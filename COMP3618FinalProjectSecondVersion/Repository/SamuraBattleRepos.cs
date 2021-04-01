
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SamuraiBattle.Data;
using SamuraiBattle.Domain;

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
        public void SeedSamuraiBattle()
        {
            var towns = new List<String>();
            towns.Add("Takoyaki");
            towns.Add("DonBuri");
            towns.Add("Sushi Town");
            towns.Add("Nagasaki");
            towns.Add("Shijuku");

            var count = towns.Count();
            if (!context.Samurais.Any())
            {
                var samurais = new List<Samurai>();
            
                for(int i  = 0; i < 10000; i++)
                {
                    var random = new Random();
                    int pickTown = random.Next(0,5);
                    var samurai = new Samurai
                    {
                        Picture = "https://static.wikia.nocookie.net/l5r/images/0/0e/Samurai.jpg",
                        Name = "Samurai_"+i,
                        Age = random.Next(0, 50),
                        Town = towns[pickTown]
                    };
                    samurais.Add(samurai);
                   
                  
                };
                context.AddRange(samurais);
                context.SaveChanges();
            }

            if (!context.Battles.Any())
            {
                var battles = new List<Battle>();
                for (int i = 0; i < 10000; i++)
                {
                    var random = new Random();
                    int pickTown = random.Next(0,5);
                    var battle = new Battle
                    {
                        FightDate = new DateTime(),
                        Name = "Round_"+i,
                        Location = towns[pickTown]
                    };
                    battles.Add(battle);
                }
                   
               
            

                context.AddRange(battles);
                context.SaveChanges();
            }
        }
    }
}
