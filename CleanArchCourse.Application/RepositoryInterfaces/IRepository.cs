using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Application.RepositoryInterfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        Task<ICollection<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<ICollection<TEntity>> Get(Expression<Func<TEntity, bool>> filter);
    }
}
