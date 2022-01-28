namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher
{
    public class GetByIdTeacherResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Star { get; set; }
        public int StudentCount { get; set; }
    }
}