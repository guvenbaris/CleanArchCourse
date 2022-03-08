using System.Threading;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub
{
    public class GetByIdCategorySubQuery :IRequestHandler<GetByIdCategorySubRequest,GetByIdCategorySubResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetByIdCategorySubQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<GetByIdCategorySubResponse> Handle(GetByIdCategorySubRequest request, CancellationToken cancellationToken)
        {
           return await _unitOfWork.CategorySub.GetCategorySubDetailById(request.Id);
        }
    }
}
