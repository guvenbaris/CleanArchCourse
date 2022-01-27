using System.Threading.Tasks;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Domain.Abstract.RepositoryInterfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> SearchOnCategory();
    }
}
