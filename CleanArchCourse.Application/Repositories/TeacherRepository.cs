using CleanArchCourse.Domain.Abstract.RepositoryInterfaces;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class TeacherRepository : Repository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(CourseContext courseContext) : base(courseContext)
        {

        }
    }
}
