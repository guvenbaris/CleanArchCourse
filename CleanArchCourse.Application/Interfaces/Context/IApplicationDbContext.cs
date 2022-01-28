using CleanArchCourse.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CategorySub> CategorySubs { get; set; }

    }
}
