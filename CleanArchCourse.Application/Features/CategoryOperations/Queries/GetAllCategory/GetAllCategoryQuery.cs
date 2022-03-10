using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory
{
    public class GetAllCategoryQuery : IRequestHandler<GetAllCategoryRequest,IEnumerable<GetAllCategoryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public GetAllCategoryQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<GetAllCategoryResponse>> Handle(GetAllCategoryRequest request, CancellationToken cancellationToken)
        {
            var categories = await _unitOfWork.Category.GetAll();
            return _mapper.Map<IEnumerable<GetAllCategoryResponse>>(categories);
        }
    }
}

