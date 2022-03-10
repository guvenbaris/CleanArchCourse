using AutoMapper;
using CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<CreateCategorySubRequest, Category>().ReverseMap();
            CreateMap<GetAllCategoryQuery, Category>().ReverseMap();
        }
    }
}
