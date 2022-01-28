using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.UpdateCategorySub
{
    public class UpdateCategorySubCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategorySubCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateCategorySubResponse> Handle(UpdateCategorySubRequest request, int id)
        {
            var categorySub = _unitOfWork.CategorySub.GetById(id);


            categorySub.Result.CategorySubName = categorySub.Result.CategorySubName != default
                ? request.CategorySubName
                : categorySub.Result.CategorySubName;

            categorySub.Result.CategoryId = categorySub.Result.CategoryId != default
                ? request.CategoryId
                : categorySub.Result.CategoryId;

            categorySub.Result.IsDeleted = request.IsDeleted;

            await _unitOfWork.CategorySub.Update(categorySub.Result);
            await _unitOfWork.SaveChanges();

            return new UpdateCategorySubResponse {Message = "CategorySub Updated"};

        }
    }
}
