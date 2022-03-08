using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher
{
    public class CreateTeacherRequest : IRequest<CreateTeacherResponse>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}