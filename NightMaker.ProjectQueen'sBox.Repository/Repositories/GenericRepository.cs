using Microsoft.EntityFrameworkCore;
using NightMaker.ProjectQueen_sBox.Core.Entities;
using NightMaker.ProjectQueen_sBox.Core.Repositories;
using NightMaker.ProjectQueen_sBox.Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Repository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected readonly SqlServerDbContext dbContext;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(SqlServerDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }
    }
}
