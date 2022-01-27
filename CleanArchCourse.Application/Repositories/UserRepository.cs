using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchCourse.Domain.Abstract.RepositoryInterfaces;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(CourseContext courseContext) : base(courseContext)
        {
        }

    }
}
