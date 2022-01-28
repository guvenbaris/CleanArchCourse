using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class TeacherRepository : Repository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(CourseContext courseContext) : base(courseContext)
        {

        }
    }
}
