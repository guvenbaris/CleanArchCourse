using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Infrastructure.Contexts;


namespace CleanArchCourse.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICourseRepository Course { get;}
        public ITeacherRepository Teacher { get;}
        public IUserRepository User { get;}

        private readonly CourseContext _context;


        public UnitOfWork(ICourseRepository course, ITeacherRepository teacher, IUserRepository user, CourseContext context)
        {
            Course = course;
            Teacher = teacher;
            User = user;
            _context = context;
        }


        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
