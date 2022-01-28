using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchCourse.Application.Dtos;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Infrastructure.Repositories
{
    public class CategorySubRepository : Repository<CategorySub>,ICategorySubRepository
    {
        private readonly CourseContext _courseContext;
        public CategorySubRepository(CourseContext courseContext) : base(courseContext)
        {
            _courseContext = courseContext;
        }

        public async Task<ICollection<CategorySubDetailDto>> GetCategorySubDetail()
        {
            var result = from cS in _courseContext.CategorySubs
                join c in _courseContext.Categories on cS.CategoryId equals c.Id
                select new CategorySubDetailDto
                {
                    CategoryName = c.CategoryName,
                    CategorySubName = cS.CategorySubName,
                    IsDeleted = cS.IsDeleted
                };
            return await result.ToListAsync();
        }

        public async Task<CategorySubDetailDto> GetCategorySubDetailById(int id)
        {
            var result = from cS in _courseContext.CategorySubs
                join c in _courseContext.Categories on cS.CategoryId equals c.Id
                where cS.Id == id 
                select new CategorySubDetailDto
                {
                    CategoryName = c.CategoryName,
                    CategorySubName = cS.CategorySubName,
                    IsDeleted = cS.IsDeleted
                };
            return await result.SingleOrDefaultAsync();
        }
    }
}

