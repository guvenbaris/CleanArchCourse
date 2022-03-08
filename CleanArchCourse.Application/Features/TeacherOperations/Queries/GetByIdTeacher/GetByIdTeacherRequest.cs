using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher
{
    public class GetByIdTeacherRequest : IRequest<GetByIdTeacherResponse>
    {
        public int Id { get; set; }
    }
}
