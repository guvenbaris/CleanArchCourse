using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Command.DeleteCategory
{
    public class DeleteCategoryRequest :IRequest<DeleteCategoryResponse>
    {
        public int Id { get; set; }
    }
}