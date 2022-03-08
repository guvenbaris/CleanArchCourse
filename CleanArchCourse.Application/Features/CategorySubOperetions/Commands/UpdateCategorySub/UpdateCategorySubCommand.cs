using System.Threading;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.UpdateCategorySub
{
    public class UpdateCategorySubCommand :IRequestHandler<UpdateCategorySubRequest,UpdateCategorySubResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategorySubCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateCategorySubResponse> Handle(UpdateCategorySubRequest request,CancellationToken cancellationToken)
        {
            var categorySub = _unitOfWork.CategorySub.GetById(request.Id);


            categorySub.Result.CategorySubName = categorySub.Result.CategorySubName != default
                ? request.CategorySubName
                : categorySub.Result.CategorySubName;

            categorySub.Result.CategoryId = categorySub.Result.CategoryId != default
                ? request.CategoryId
                : categorySub.Result.CategoryId;

            categorySub.Result.IsDeleted = request.IsDeleted;

            await _unitOfWork.CategorySub.Update(categorySub.Result);
            await _unitOfWork.SaveChanges();

            return new UpdateCategorySubResponse { Message = "CategorySub Updated" };
        }
    }
}
