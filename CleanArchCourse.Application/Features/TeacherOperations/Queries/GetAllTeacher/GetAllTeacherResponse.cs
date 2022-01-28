using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher
{
    public class GetAllTeacherResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Star { get; set; }
        public int StudentCount { get; set; }
    }
}
