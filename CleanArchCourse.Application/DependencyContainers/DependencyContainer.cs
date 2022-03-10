using System;
using MediatR;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using CleanArchCourse.Application.Features.CategoryOperations.Command.CreateCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Command.DeleteCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Command.UpdateCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Queries.GetByIdCategory;
using CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Command.DeleteTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Command.UpdateTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.DeleteCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.UpdateCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub;

namespace CleanArchCourse.Application.DependencyContainers
{
    public static class DependencyContainer
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<GetAllCategorySubQuery>();
            services.AddTransient<GetByIdCategorySubQuery>();
            services.AddTransient<CreateCategorySubCommand>();
            services.AddTransient<DeleteCategorySubCommand>();
            services.AddTransient<UpdateCategorySubCommand>();

            services.AddTransient<GetAllTeacherQuery>();
            services.AddTransient<GetByIdTeacherQuery>();
            services.AddTransient<CreateTeacherCommand>();
            services.AddTransient<UpdateTeacherCommand>();
            services.AddTransient<DeleteTeacherCommand>();


            services.AddTransient<CreateCategoryCommand>();
            services.AddTransient<DeleteCategoryCommand>();
            services.AddTransient<UpdateCategoryCommand>();
            services.AddTransient<GetAllCategoryQuery>();
            services.AddTransient<GetByIdCategoryQuery>();
        }
    }
}
