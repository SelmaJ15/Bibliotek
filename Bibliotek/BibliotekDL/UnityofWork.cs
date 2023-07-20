using BibliotekEntiteter;

namespace BibliotekDL
{
    public class UnitOfWork
    {
        private BibliotekContext context;
        public Repository<Bok> BokRepository
        {
            get; private set;
        }

        public Repository<Medlem> MedlemRepository
        {
            get; private set;
        }

        public Repository<Bokning> BokningRepository
        {
            get; private set;
        }

        public Repository<Faktura> FakturaRepository
        {
            get; private set;
        }

        public Repository<Expedit> ExpeditRepository
        {
            get; private set;
        }

        ///  Create a new instance.
        public UnitOfWork()
        {
            context = new BibliotekContext();
            BokRepository = new Repository<Bok>();
            MedlemRepository = new Repository<Medlem>();
            BokningRepository = new Repository<Bokning>();
            FakturaRepository = new Repository<Faktura>();
            ExpeditRepository = new Repository<Expedit>();

            // Initialize the tables if this is the first UnitOfWork.
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
