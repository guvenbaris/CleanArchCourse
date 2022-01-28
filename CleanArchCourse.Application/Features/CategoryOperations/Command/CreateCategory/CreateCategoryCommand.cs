using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Features.CategoryOperations.Command.CreateCategory
{ public class CreateCategoryCommand
    {
        readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommand(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task Handle(Category category)
        { 
            await _categoryRepository.Add(category);
        }

    }
}

