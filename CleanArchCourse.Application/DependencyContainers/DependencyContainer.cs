using CleanArchCourse.Infrastructure.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchCourse.Infrastructure.DependencyContainers
{
    public static class DependencyContainer 
    {

        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {

            //ConnectionString tanımladığında isminin default olması gerekiyor !!!NOT!!!
            return services.AddDbContext<CourseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("default")));
        }
    }
}
