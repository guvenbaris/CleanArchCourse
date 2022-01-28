using System.Threading.Tasks;
using CleanArchCourse.Application.Dtos;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub
{
    public class GetByIdCategorySubQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetByIdCategorySubQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CategorySubDetailDto> Handle(int id) => await _unitOfWork.CategorySub.GetCategorySubDetailById(id);
    }
}
