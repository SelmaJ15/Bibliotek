using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekEntiteter
{
    public class Bok
    {
        public int bokID { get; set; }
        public string ISBN { get; set; }
        public string titel { get; set; }
        public bool ärTillgänglig { get; set; }
        public Bok()
        {

        }
        public Bok(string iSBN, string t, bool ÄrTillgänglig)
        {
            ISBN = iSBN;
            titel = t;
            ärTillgänglig = ÄrTillgänglig;
        }

        
        
    }
}