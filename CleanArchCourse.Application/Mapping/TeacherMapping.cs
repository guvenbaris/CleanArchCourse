using AutoMapper;
using CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Mapping
{
    public class TeacherMapping : Profile
    {
        public TeacherMapping()
        {
            CreateMap<Teacher, CreateTeacherResponse>().ReverseMap();
            CreateMap<Teacher, CreateTeacherRequest>().ReverseMap();
            CreateMap<Teacher, GetByIdTeacherResponse>().ReverseMap();
        }
    }
}
