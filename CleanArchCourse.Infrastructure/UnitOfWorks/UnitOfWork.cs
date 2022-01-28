using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;


namespace CleanArchCourse.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICourseRepository Course { get;}
        public ITeacherRepository Teacher { get;}
        public IUserRepository User { get;}
        public ICategorySubRepository CategorySub { get; }
        public ICategoryRepository Category { get; }


        private readonly CourseContext _context;


        public UnitOfWork(ICourseRepository course, ITeacherRepository teacher, IUserRepository user,ICategorySubRepository categorySub, CourseContext context, ICategoryRepository category)
        {
            Course = course;
            Teacher = teacher;
            User = user;
            CategorySub = categorySub;
            Category = category;
            _context = context;
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
