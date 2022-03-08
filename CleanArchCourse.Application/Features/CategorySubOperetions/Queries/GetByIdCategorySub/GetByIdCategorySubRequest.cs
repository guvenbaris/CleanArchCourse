using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub
{
    public class GetByIdCategorySubRequest :IRequest<GetByIdCategorySubResponse>
    {
        public int  Id { get; set; }
    }
}
