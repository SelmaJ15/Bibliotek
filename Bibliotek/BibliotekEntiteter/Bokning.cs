using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekEntiteter
{
    public class Bokning
    {
       public int bokningId { get; set; } 
        public int medlemId { get; set; }
        public DateTime tilltänktaUtlämningstid { get; set; }
        public DateTime faktiskaUtlämningstid { get; set; }
        public DateTime tilltänktaÅterlämningstid { get; set; }
        public DateTime faktiskaÅterlämningstid { get; set; }
        public List<Bok> TillhörandeBöcker { get; set; }

        public Bokning()
        {

        }
        public Bokning(int bId, int m, DateTime t2)
        {
            bokningId = bId;
            medlemId = m;
            tilltänktaÅterlämningstid = t2;
        }
    }

}
