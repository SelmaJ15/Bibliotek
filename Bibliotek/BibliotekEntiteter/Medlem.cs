using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekEntiteter
{
    public class Medlem
    {
        public int medlemID
        {
            get; set;
        }

        public string namn
        {
            get; set;
        }

        public string nummer
        {
            get; set;
        }

        public string epost
        {
            get; set;
        }
        public List<Bokning> TillhörandeBokningar { get; set; }
        public Medlem()
        {

        }
        public Medlem( string nam, string nr, string e)
        {
            
            namn = nam;
            nummer = nr;
            epost = e;
            TillhörandeBokningar = new List<Bokning>();
        }
    }
}
