using AutoMapper;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Mapping
{
    public class CategorySubMapping : Profile
    {
        public CategorySubMapping()
        {
            CreateMap<CategorySub, CreateCategorySubRequest>().ReverseMap();
            CreateMap<CategorySub, CreateCategorySubResponse>().ReverseMap();
        }
    }
}
