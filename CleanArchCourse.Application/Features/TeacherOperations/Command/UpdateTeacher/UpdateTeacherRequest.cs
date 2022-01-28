namespace CleanArchCourse.Application.Features.TeacherOperations.Command.UpdateTeacher
{
    public class UpdateTeacherRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDeleted { get; set; }

    }
}