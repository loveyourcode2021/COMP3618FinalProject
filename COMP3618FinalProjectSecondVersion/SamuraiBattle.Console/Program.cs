using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using SamuraiBattle.Data;
using SamuraiBattle.Domain;

namespace SamuraiBattle.Console
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var context = new SamuraiBattleContext();
            var er = new Repository();
            er.SeedSamuraiBattle(context);
            
        }
    }  
}
