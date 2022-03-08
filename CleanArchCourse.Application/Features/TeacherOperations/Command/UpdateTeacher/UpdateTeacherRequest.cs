using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.UpdateTeacher
{
    public class UpdateTeacherRequest : IRequest<UpdateTeacherResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDeleted { get; set; }
    }
}