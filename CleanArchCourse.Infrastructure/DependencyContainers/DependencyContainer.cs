using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;
using CleanArchCourse.Infrastructure.Contexts;
using CleanArchCourse.Infrastructure.Repositories;
using CleanArchCourse.Infrastructure.UnitOfWorks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchCourse.Infrastructure.DependencyContainers
{
    public static class DependencyContainer 
    {
        public static void AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<CourseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("default")));
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}




