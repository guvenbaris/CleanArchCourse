using System.Collections.Generic;
using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub
{
    public class GetAllCategorySubRequest : IRequest<IEnumerable<GetAllCategorySubResponse>>
    {
    }
}
