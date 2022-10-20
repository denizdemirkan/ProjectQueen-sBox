using NightMaker.ProjectQueen_sBox.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Services
{
    public interface IGenericService<TEntity> where TEntity : IEntity, new()
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> GetAll();
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
