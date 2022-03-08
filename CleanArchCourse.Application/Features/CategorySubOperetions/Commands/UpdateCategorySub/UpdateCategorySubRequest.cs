using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.UpdateCategorySub
{
    public class UpdateCategorySubRequest :IRequest<UpdateCategorySubResponse>
    {
        public int Id { get; set; }
        public string CategorySubName { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}

