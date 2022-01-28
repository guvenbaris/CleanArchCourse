using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;


namespace CleanArchCourse.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course>,ICourseRepository
    {
        public CourseRepository(CourseContext courseContext) : base(courseContext)
        {

        }

    }
}
