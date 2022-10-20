using Microsoft.EntityFrameworkCore;
using NightMaker.ProjectQueen_sBox.Core.Entities;
using NightMaker.ProjectQueen_sBox.Core.Repositories;
using NightMaker.ProjectQueen_sBox.Core.Services;
using NightMaker.ProjectQueen_sBox.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Service.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly IGenericRepository<TEntity> genericRepository;
        private readonly IUnitOfWork unitOfWork;

        public GenericService(IGenericRepository<TEntity> genericRepository, IUnitOfWork unitOfWork)
        {
            this.genericRepository = genericRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task AddAsync(TEntity entity)
        {
            await genericRepository.AddAsync(entity);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await genericRepository.GetAll().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await genericRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            genericRepository.Remove(entity);
            await unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            genericRepository.Update(entity);
            await unitOfWork.CommitAsync();
        }
    }
}
