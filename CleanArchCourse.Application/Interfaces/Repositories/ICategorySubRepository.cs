using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchCourse.Application.Dtos;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Interfaces.Repositories
{
    public interface ICategorySubRepository : IRepository<CategorySub>
    {
        Task<ICollection<CategorySubDetailDto>> GetCategorySubDetail();
        Task<CategorySubDetailDto> GetCategorySubDetailById(int id);
    }
}
