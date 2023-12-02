using BIT.Data.DbHelper;
using Microsoft.EntityFrameworkCore;
using System;
using BIT.Data.DbHelper;
using BudgetManagerAPI.Data.Entities;

namespace BudgetManagerAPI.Data.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public T GetById(int id)
        {
            var entity = _dbSet.FirstOrDefault(e => e.Id == id);
            return entity != null ? entity : throw new ArgumentNullException(nameof(entity), $"Entity with Id {id} not found.");
        }
        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}