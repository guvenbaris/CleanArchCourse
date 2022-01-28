using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher
{
    public class GetAllTeacherQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTeacherQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<GetAllTeacherResponse>> Handle() =>
            _mapper.Map<ICollection<GetAllTeacherResponse>>(await _unitOfWork.Teacher.GetAll());
    }
}
