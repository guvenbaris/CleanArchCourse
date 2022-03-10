using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub
{
    public class GetAllCategorySubQuery : IRequestHandler<GetAllCategorySubRequest,IEnumerable<GetAllCategorySubResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllCategorySubQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }


        public async Task<IEnumerable<GetAllCategorySubResponse>> Handle(GetAllCategorySubRequest request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.CategorySub.GetCategorySubDetail();
        }
    }

}

