using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekEntiteter
{
    public class Faktura
    {
        public int fakturaID { get; set; }
        public Bokning bokning { get; private set; }
        public Expedit expedit { get; private set; }
        public float totalpris { get; private set; }
        public DateTime faktiskaÅterlämningstid { get; private set; }
        public Faktura()
        {

        }
        public Faktura(Bokning b, Expedit e)
        {
            bokning = b;
            expedit = e;
            faktiskaÅterlämningstid = DateTime.Now;
            TimeSpan dateDiff = faktiskaÅterlämningstid.Date - bokning.tilltänktaÅterlämningstid.Date;
            if (dateDiff.Days == 0 || dateDiff.Days < 0)
            {
                totalpris = 0;
            }
            else
            {
                totalpris = dateDiff.Days * 10;
            }


        }
        
    }
}
