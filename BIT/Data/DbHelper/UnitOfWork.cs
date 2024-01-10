using BIT.Data.Repositories;
using BIT.Data.Repositories.IRepository;

namespace BIT.Data.DbHelper
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPaxRepository Pax { get; private set; }
        private ApplicationDbContext _db;
      

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Pax = new PaxRepository(_db);
        }

        public void SaveChanges()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception exception)
            {
                var errorMessage = "Error when saving to the database: "
                                   + $"{exception.Message}\n\n"
                                   + $"{exception.InnerException}\n\n"
                                   + $"{exception.StackTrace}\n\n";

                Console.WriteLine(errorMessage);
            }
        }
    }
}
