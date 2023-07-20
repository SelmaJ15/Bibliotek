using BibliotekEntiteter;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;



namespace BibliotekDL
{
    public class BibliotekContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sqlutb2.hb.se,56077;Database=osu2314;User Id=osu2314;Password=xy5854;");
            base.OnConfiguring(optionsBuilder);
        }
        public BibliotekContext()
        {

        }
        public DbSet<Bok> Böcker { get; set; }
        public DbSet<Bokning> Bokningar { get; set; }
        public DbSet<Expedit> Expediter { get; set; }
        public DbSet<Medlem> Medlemmar { get; set; }
        public DbSet<Faktura> Fakturor { get; set; }

        public void Reset()

        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Database.ExecuteSqlRaw("EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
                    Database.ExecuteSqlRaw("EXEC sp_MSforeachtable 'DROP TABLE ?'");
                }
                catch (System.Exception) { }
            }
        }
             public void resetSeed()
            {
                Reset();
                Database.EnsureCreated();

                Bok bok1 = new Bok("LP10", "Little Prince", true);
                Böcker.Add(new Bok("PP11", "Pride and prejudice", false));
                Böcker.Add(new Bok("H12", "Hamlet", true));
                Böcker.Add(new Bok("RL13", "40 Rules of Love", true));
                Böcker.Add(new Bok("A14", "Alchemist", true));
                Böcker.Add(new Bok("VD15", "Veronika decides to die", true));
                
                Böcker.Add(bok1);

                Expediter.Add(new Expedit("1", "Sara Holmgren", "secret123", "expedit"));
                Expediter.Add(new Expedit("2", "Julia Holm", "1234", "expedit"));

                Medlem m1 = new Medlem( "Klara Jackson", "+46515487525", "klara.jackson@gmail.com");
                Medlemmar.Add(new Medlem( "Thomas Grey", "+46515747558", "thomas.grey@gmail.com"));
                Medlemmar.Add(m1);

                SaveChanges();

            }
        }
    }

