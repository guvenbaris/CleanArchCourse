using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArchCourse.Application.DependencyContainers
{
    public static class DependencyContainer
    {
        public static void AddApplicationServices(this IServiceCollection service)
        {

            service.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
