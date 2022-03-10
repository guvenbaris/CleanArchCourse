using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Command.CreateCategory
{
    public class CreateCategoryRequest :IRequest<CreateCategoryResponse>
    {
        public string CategoryName { get; set; }
    }
}