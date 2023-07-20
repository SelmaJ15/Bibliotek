using System;
using System.Collections.Generic;
using BibliotekDL;
using BibliotekEntiteter;
namespace BibliotekAL
{
    public class Bibliotek
    {

        public Expedit LoggedIn
        {
            get; private set;
        }
        public UnitOfWork unitOfWork = new UnitOfWork();



        ///  Logga in i bibliotek
        /// <param namn="expeditID"></param>
        /// <param namn="lösenord"></param>
        /// Returnerar true om login är rätt eller false om den inte är rätt
        public bool LoggaIn(string expeditID, string lösenord)
        {
            Expedit m = unitOfWork.ExpeditRepository.FirstOrDefault(ex => ex.anställningsNr == expeditID);
            if (m != null && m.VerifieraLösenord(lösenord))
            {
                LoggedIn = m;
                return true;
            }
            LoggedIn = null;
            return false;
        }


        /// Bok reservation
        /// <param namn="bok">Boken som ska bli reserverad</param>
        /// <returns>reservation.</returns>
        public Bokning ReserveraBok(int medlemId,  DateTime dateTo)
        {
            int randomInt = new Random().Next(100);
            Bokning r = new Bokning(randomInt, medlemId, dateTo);
            unitOfWork.BokningRepository.Add(r);

            
            
            unitOfWork.Save();
            return r;
        }

        

        public IList<Bokning> HämtaBokningar(int medlemId)
        {
            List<Bokning> Bokningar = new List<Bokning>();
            foreach (Bokning b in unitOfWork.BokningRepository.Find(c => c.medlemId == medlemId))
            {
                Bokningar.Add(b);
            }
            return Bokningar;
        }

        public IEnumerable<Bok> HämtaTillgängligaBöcker()
        {
            return unitOfWork.BokRepository.Find(b => b.ärTillgänglig == true);
        }
        public Bokning HämtaBokningen(Bokning bokningen)
        {
            Bokning bokningTest = bokningen;
            bokningTest.tilltänktaÅterlämningstid = DateTime.Now;

            //unitOfWorkef.BokningRepository.Add(bokning);
            unitOfWork.Save();

            return bokningTest;
        }
        public Bokning LäggTillBok(Bok b, Bokning bokning)
        {
            b.ärTillgänglig = false;
            bokning.TillhörandeBöcker.Add(b);
            unitOfWork.Save(); //this one important now when using database/EF

            return bokning;
        }

        /// <summary>
        ///  Returnera en bok
        /// </summary>
        /// <param namn="bok">Boken ska bli returnerad</param>
        /// <returns>Faktura</returns>
        /// <exception cref="ApplicationException"></exception>
        public Faktura Återlämning(int bokningId)
        {
           
            Bokning bokning = unitOfWork.BokningRepository.FirstOrDefault(b => b.bokningId == bokningId);
            Faktura faktura = new Faktura(bokning, LoggedIn);


            foreach (Bok bok in bokning.TillhörandeBöcker)
            {
                bok.ärTillgänglig = true;
            }
            unitOfWork.BokningRepository.Remove(bokning);
            unitOfWork.Save();
            return faktura;

        }
        public BibliotekDL.UnitOfWork UnitOfWork;
        
    }
}