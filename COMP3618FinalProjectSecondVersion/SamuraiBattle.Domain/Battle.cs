using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiBattle.Domain
{
    public class Battle
    {
        public int BattleID { get; set; } //#A
        public DateTime FightDate { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
  

        //relationship
        public List<Battle> Battles { get; set; } //#B
    }
}
