using System.Net;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher
{
    public class CreateTeacherRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}