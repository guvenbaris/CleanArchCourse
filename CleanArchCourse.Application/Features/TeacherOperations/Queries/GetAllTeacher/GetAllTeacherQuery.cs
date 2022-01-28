using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.Repositories;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher
{
    public class GetAllTeacherQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllTeacherQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ICollection<Teacher>> Handle() => await _unitOfWork.Teacher.GetAll();
    }
}
