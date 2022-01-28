using System.Threading.Tasks;
using CleanArchCourse.Application.Exceptions;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.DeleteCategorySub
{
    public class DeleteCategorySubCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategorySubCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteCategorySubResponse> Handle(int id)
        {
            var categorySub = _unitOfWork.CategorySub.GetById(id);
            if (categorySub is null)
            {
                throw new NotFoundExceptions(nameof(categorySub), id);
            }

            await _unitOfWork.CategorySub.Delete(categorySub.Result);
            await _unitOfWork.SaveChanges();

            return new DeleteCategorySubResponse {Messages = $"CategorySub deleted"};
        }

    }
}
