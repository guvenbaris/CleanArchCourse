using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(CourseContext courseContext) : base(courseContext)
        {

        }

        public  Category SearchOnCategory()
        {
            Category category = new()
            {
                CategoryName = "Merhaba",
                IsDeleted = true
            };
            return category;
        }
    }
}
