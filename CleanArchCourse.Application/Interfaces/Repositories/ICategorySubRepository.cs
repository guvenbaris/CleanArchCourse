using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Interfaces.Repositories
{
    public interface ICategorySubRepository : IRepository<CategorySub>
    {
        Task<IEnumerable<GetAllCategorySubResponse>> GetCategorySubDetail();
        Task<GetByIdCategorySubResponse> GetCategorySubDetailById(int id);
    }
}

