using BIT.Data.DbHelper;
using BIT.Data.Entities;
using BIT.Data.Repositories.IRepository;
using BudgetManagerAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BIT.Data.Repositories
{
    public class PaxRepository:Repository<Pax>, IPaxRepository
    {
        private ApplicationDbContext _db;
        public PaxRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Pax obj)
        {
            _db.Pax.Update(obj);
        }
    }
}
