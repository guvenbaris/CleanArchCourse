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
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(CourseContext courseContext) : base(courseContext)
        {

        }

        public Task<Category> SearchOnCategory()
        {
            throw new NotImplementedException();
        }
    }
}
