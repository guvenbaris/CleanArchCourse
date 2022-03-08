using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Application.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task Add(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
        Task<IEnumerable< TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<IEnumerable< TEntity>> Get(Expression<Func<TEntity, bool>> filter);
    }
}

