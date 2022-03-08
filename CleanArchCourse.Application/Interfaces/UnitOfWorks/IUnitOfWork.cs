using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;

namespace CleanArchCourse.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICourseRepository Course { get; }
        ITeacherRepository Teacher { get; }
        IUserRepository User { get; }
        ICategorySubRepository  CategorySub { get; }
        ICategoryRepository Category { get; }
        Task<int> SaveChanges();
    }
}
