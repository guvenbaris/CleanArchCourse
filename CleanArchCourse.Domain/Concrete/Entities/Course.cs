using System;
using System.Collections.Generic;
using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Domain.Concrete.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<User> Users { get; set; }
        public DateTime PublishDate { get; set; }
        public float Star { get; set; }

        //CourseContent Gelecek One-To-Many
    }
}
