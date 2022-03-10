using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;
using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Command.CreateCategory
{ public class CreateCategoryCommand :IRequestHandler<CreateCategoryRequest,CreateCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoryCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<CreateCategoryResponse> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            category.IsDeleted = false;
            await _unitOfWork.Category.Add(category);

            if (await _unitOfWork.SaveChanges() > 0) return new CreateCategoryResponse {Message = "Category saved"};
            return new CreateCategoryResponse
            {
                Success = false,
                Message = "Category did not saved"
            };

        }
    }
}

