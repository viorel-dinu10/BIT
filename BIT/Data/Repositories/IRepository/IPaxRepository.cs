using System.ComponentModel;
using System.Linq.Expressions;
using BIT.Data.Entities;

namespace BIT.Data.Repositories.IRepository
{
    public interface IPaxRepository : IRepository<Pax>
    {
        void Update(Pax obj);
    }
}
