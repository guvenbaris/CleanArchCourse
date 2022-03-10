using System.Collections.Generic;
using MediatR;

namespace CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory
{
    public class GetAllCategoryRequest :IRequest<GetAllCategoryResponse>, IRequest<IEnumerable<GetAllCategoryResponse>>
    {

    }
}