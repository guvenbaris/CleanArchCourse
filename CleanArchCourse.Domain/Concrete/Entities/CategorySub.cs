using CleanArchCourse.Domain.Abstract.Entity;

namespace CleanArchCourse.Domain.Concrete.Entities
{
    public class CategorySub : BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string CategorySubName { get; set; }
    }
}
