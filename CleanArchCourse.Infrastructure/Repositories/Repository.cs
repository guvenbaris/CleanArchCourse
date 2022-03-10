using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Abstract.Entity;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>  where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> _dbSet;

        public Repository(CourseContext courseContext)
        {
            _dbSet = courseContext.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
           await _dbSet.AddAsync(entity);
        }
        public Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return  Task.CompletedTask;
        }

        public Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.Where(filter).ToListAsync();
        }
    }
}

