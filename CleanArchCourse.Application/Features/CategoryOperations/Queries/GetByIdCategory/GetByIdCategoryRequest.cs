using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Queries.GetByIdCategory
{
    public class GetByIdCategoryRequest : IRequest<GetByIdCategoryResponse>
    {
        public int Id { get; set; }
    }
}