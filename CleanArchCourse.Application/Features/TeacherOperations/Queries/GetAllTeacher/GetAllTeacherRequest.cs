using System.Collections.Generic;
using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher
{
    public class GetAllTeacherRequest : IRequest<IEnumerable<GetAllTeacherResponse>>
    {
    }
}
