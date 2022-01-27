using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchCourse.Domain.Abstract.RepositoryInterfaces;

namespace CleanArchCourse.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICourseRepository Course { get; }
        ITeacherRepository Teacher { get; }
        IUserRepository User { get; }
        Task<int> SaveChanges();
    }
}
