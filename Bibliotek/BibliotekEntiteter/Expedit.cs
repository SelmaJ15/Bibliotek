using System;

namespace BibliotekEntiteter
{
    public class Expedit
    {
        public int expeditID { get; set; }
        public string anställningsNr { get;  set; }
        public string namn { get;  set; }
        public string lösenord { get; set; }
        public string roll { get; set; }
        public Expedit()
        {

        }
        public Expedit(string AnställningsNr, string Namn, string Lösenord, string Roll)
        {
            anställningsNr = AnställningsNr;
            namn = Namn;
            lösenord = Lösenord;
            roll = Roll;
        }

        public bool VerifieraLösenord(string given)
        {
            return lösenord == given;
        }
    }
}
