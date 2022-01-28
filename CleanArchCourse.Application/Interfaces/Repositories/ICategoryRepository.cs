using CleanArchCourse.Domain.Concrete.Entities;


namespace  CleanArchCourse.Application.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category SearchOnCategory();
    }
}
