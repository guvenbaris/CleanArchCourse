using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Queries.GetByIdCategory
{
    public class GetByIdCategoryQuery : IRequestHandler<GetByIdCategoryRequest, GetByIdCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public GetByIdCategoryQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<GetByIdCategoryResponse> Handle(GetByIdCategoryRequest request, CancellationToken cancellationToken)
        {
            var category =  await _unitOfWork.Category.GetById(request.Id);
            return _mapper.Map<GetByIdCategoryResponse>(category);
        }
    }
}
