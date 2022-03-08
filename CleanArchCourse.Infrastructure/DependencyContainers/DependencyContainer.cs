using System.Reflection;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Infrastructure.Contexts;
using CleanArchCourse.Infrastructure.Repositories;
using CleanArchCourse.Infrastructure.UnitOfWorks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategorySubRepository, CategorySubRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}




