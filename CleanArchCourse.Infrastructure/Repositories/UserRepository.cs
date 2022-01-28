using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(CourseContext courseContext) : base(courseContext)
        {
        }

    }
}
