using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.DeleteCategorySub
{
    public class DeleteCategorySubRequest : IRequest<DeleteCategorySubResponse>
    {
        public int Id { get; set; }
    }
}

