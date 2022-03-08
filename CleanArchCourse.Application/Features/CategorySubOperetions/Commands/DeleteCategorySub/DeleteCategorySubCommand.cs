using System.Threading;
using System.Threading.Tasks;
using CleanArchCourse.Application.Exceptions;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.DeleteCategorySub
{
    public class DeleteCategorySubCommand :IRequestHandler<DeleteCategorySubRequest,DeleteCategorySubResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategorySubCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<DeleteCategorySubResponse> Handle(DeleteCategorySubRequest request, CancellationToken cancellationToken)
        {
            var categorySub = _unitOfWork.CategorySub.GetById(request.Id);
            if (categorySub is null)
            {
                throw new NotFoundExceptions(nameof(categorySub), request.Id);
            }

            await _unitOfWork.CategorySub.Delete(categorySub.Result);
            await _unitOfWork.SaveChanges();

            return new DeleteCategorySubResponse { Messages = $"CategorySub deleted" };
        }
    }
}
