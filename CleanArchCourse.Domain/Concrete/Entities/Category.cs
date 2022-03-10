using System.Collections.Generic;
using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Domain.Concrete.Entities
{
    public class Category :BaseEntity
    {
        public string CategoryName { get; set; }
        public IEnumerable<CategorySub> CategorySubs { get; set; }
    }
}

