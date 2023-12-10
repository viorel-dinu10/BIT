using BIT.Data.Repositories;

namespace BIT.Data.DbHelper
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _dbContext;
        public PaxRepository Pax { get; set; }

        public UnitOfWork
        (
            ApplicationDbContext dbContext,
            PaxRepository paxRepository
        )
        {
            _dbContext = dbContext;
            Pax = paxRepository;
        }

        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
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
