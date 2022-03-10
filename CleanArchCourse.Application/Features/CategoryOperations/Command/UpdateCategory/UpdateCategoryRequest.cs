using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Command.UpdateCategory
{
    public class UpdateCategoryRequest :IRequest<UpdateCategoryResponse>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}