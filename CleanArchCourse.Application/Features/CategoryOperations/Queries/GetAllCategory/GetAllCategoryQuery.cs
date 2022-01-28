using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory
{
    public class GetAllCategoryQuery
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoryQuery(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ICollection<Category>> Handle() => await _categoryRepository.GetAll();
    }
}

