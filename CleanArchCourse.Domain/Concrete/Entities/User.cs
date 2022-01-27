using System.Collections.Generic;
using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Domain.Concrete.Entities
{
    public class User : BaseEntity,IBasePerson<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
