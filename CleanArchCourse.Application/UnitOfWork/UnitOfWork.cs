using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchCourse.Domain.Abstract.RepositoryInterfaces;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using CleanArchCourse.Infrastructure.Repositories;

namespace CleanArchCourse.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private  ICategoryRepository _category;
        private  ICourseRepository _course;
        private  ITeacherRepository _teacher;
        private  IUserRepository _user;
        private readonly CourseContext _context;

        public ICategoryRepository Category
        {
            get
            {
                if (_category is null)
                {
                    _category = new CategoryRepository(_context);
                }

                return _category;
            }
        }

        public ICourseRepository Course
        {
            get
            {
                if (_course is null)
                {
                    _course = new CourseRepository(_context);
                }

                return _course;
            }
        }

        public ITeacherRepository Teacher
        {
            get
            {
                if (_teacher is null)
                {
                    _teacher = new TeacherRepository(_context);
                }

                return _teacher;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user is null)
                {
                    _user = new UserRepository(_context);
                }

                return _user;
            }
              
        }
        
        public UnitOfWork(CourseContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
