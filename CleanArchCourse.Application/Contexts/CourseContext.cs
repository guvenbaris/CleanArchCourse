﻿using CleanArchCourse.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCourse.Infrastructure.Contexts
{
    public class CourseContext :DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options):base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
