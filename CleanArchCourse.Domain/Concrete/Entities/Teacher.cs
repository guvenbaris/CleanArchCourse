using System.Collections.Generic;
using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Domain.Concrete.Entities
{
    public class Teacher :BaseEntity,IBasePerson<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Star { get; set; }
        public int StudentCount { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
