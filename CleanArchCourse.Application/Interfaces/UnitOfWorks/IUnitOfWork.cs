using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;

namespace CleanArchCourse.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICourseRepository Course { get; }
        ITeacherRepository Teacher { get; }
        IUserRepository User { get; }
        Task<int> SaveChanges();
    }
}
