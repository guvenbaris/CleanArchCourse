using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ICollection<Category>> GetAll()
        {
            GetAllCategoryQuery query = new(_categoryRepository);

            return await query.Handle();
        }
    }
}
