using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Dtos;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub
{
    public class GetAllCategorySubQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllCategorySubQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ICollection<CategorySubDetailDto>> Handle() => await _unitOfWork.CategorySub.GetCategorySubDetail();

    }

}

