using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CleanArchCourse.Domain.Abstract.Entity;
using CleanArchCourse.Domain.Abstract.RepositoryInterfaces;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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
        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<ICollection<TEntity>> GetAll()
        {
           return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.Where(filter).ToListAsync();
        }
    }
}
