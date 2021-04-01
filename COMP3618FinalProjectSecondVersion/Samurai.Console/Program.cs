using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using SamuraiBattle.Data;
using SamuraiBattle.Domain;

namespace Samurai.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SamuraBattleRepos er = new SamuraBattleRepos();
            er.SeedSamuraiBattle();
        }
    }
}
