using BIT.Data.Entities;
using BIT.Data.Repositories.IRepository;

namespace BIT.Data.DbHelper
{
    public interface IUnitOfWork
    {

        IPaxRepository Pax { get; }
        public void SaveChanges();
    }
}
