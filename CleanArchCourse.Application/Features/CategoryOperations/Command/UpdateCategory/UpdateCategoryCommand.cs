using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;


namespace CleanArchCourse.Application.Features.CategoryOperations.Command.UpdateCategory
{
    public class UpdateCategoryCommand :IRequestHandler<UpdateCategoryRequest,UpdateCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCategoryCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateCategoryResponse> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
        {

            var category = _mapper.Map<Category>(request);
            await _unitOfWork.Category.Update(category);
            await _unitOfWork.SaveChanges();

            return new UpdateCategoryResponse{Message = "Category updated"};
        }
    }
}
