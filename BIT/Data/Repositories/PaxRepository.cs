using BIT.Data.DbHelper;
using BIT.Data.Entities;
using BudgetManagerAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BIT.Data.Repositories
{
    public class PaxRepository:BaseRepository<Pax>
    {
        public PaxRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
