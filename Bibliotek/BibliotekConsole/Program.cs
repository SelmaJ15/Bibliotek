using System;
using BibliotekAL;
using System.Collections.Generic;
using BibliotekEntiteter;


namespace BibliotekConsole
{
    public class Program
    {
        private Bibliotek bibliotek;

        static void Main(string[] args)
        {
            new Program().Main();
        }

        private Program()
        {
            bibliotek = new Bibliotek();
        }

        private void Main()
        {
            Console.WriteLine("Välkommen till Borås Bibliotek!");
            while (true)
            {
                try
                {
                    if (LogIn())
                        {
                            Console.WriteLine("Du är inloggad!");
                            Console.WriteLine("Vill du:");
                            Console.WriteLine("1. Reservera en bok eller ");
                            Console.WriteLine("2. Återlämna en bok ");
                            Console.WriteLine("Tryck 1 eller 2:  ");
                            string option = Console.ReadLine();
                            if (option == "1")
                            {
                                ReserveraBok();
                            }
                            else
                            {
                                ÅterlämnaBok();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Går ej att logga in.");
                        }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }

        private string ÅterlämnaBok()
        {
            Console.Write("Vänligen ange boknings ID:");
            string bokningId = Console.ReadLine();
            Faktura faktura = bibliotek.återlämning(Convert.ToInt32(bokningId));

            return faktura.ToString();


        }

        private void ReserveraBok()
        {
            IList<Bok> tillgänglig = bibliotek.GetAvailableBooks();
            int i = 0;
            foreach (Bok b in tillgänglig)
            { 
                Console.Write("{0}. ", i++);
                Console.Write(b.ToString());
            }
            Console.Write("Vänligen välj en bok efter dess ISBN nummer:");
            string valdBokId = Console.ReadLine();

            Console.Write("Vänligen ange medlems ID som vill resevera boken:");
            string medlemId = Console.ReadLine();

            bibliotek.ReserveraBok(Convert.ToInt32(medlemId), tillgänglig[Convert.ToInt32(valdBokId) - 1]);
        }

        private bool LogIn()
        {
            string inputID = "";
            int id;
            while (!int.TryParse(inputID, out id))
            {
                Console.WriteLine("Skriv in ditt anställningsnummer: ");
                inputID = Console.ReadLine();
            }
            Console.WriteLine("Skriv in ditt lösenord: ");
            string lösenord = Console.ReadLine();

            return bibliotek.LoggaIn(id, lösenord);
        }


    }
}
