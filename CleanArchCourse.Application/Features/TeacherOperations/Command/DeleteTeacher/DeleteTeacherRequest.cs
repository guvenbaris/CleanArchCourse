using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.DeleteTeacher
{
    public class DeleteTeacherRequest : IRequest<DeleteTeacherReponse>
    {
        public int Id { get; set; }
    }
}
