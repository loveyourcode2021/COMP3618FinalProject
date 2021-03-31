using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiBattle.Domain
{
    public class Samurai
    {
        public int SamuraiID { get; set; } //#A
        public string Picture { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        //relationship
        public List<Samurai> Samurais { get; set; } //#B
    }
}
