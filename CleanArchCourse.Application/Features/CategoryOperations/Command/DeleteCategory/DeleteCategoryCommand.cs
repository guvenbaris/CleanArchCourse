using System.Threading;
using System.Threading.Tasks;
using CleanArchCourse.Application.Exceptions;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Command.DeleteCategory
{
    public class DeleteCategoryCommand : IRequestHandler<DeleteCategoryRequest,DeleteCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteCategoryResponse> Handle(DeleteCategoryRequest request, CancellationToken cancellationToken)
        {
            var category =await  _unitOfWork.Category.GetById(request.Id);
            if (category is null)
            {
                throw new NotFoundExceptions("Category", request.Id);
            }

            await _unitOfWork.Category.Delete(category);
            await _unitOfWork.SaveChanges();
            return new DeleteCategoryResponse {Message = "Category deleted"};
        }
    }
}
