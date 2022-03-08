using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher
{
    public class GetAllTeacherQuery : IRequestHandler<GetAllTeacherRequest,IEnumerable<GetAllTeacherResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTeacherQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAllTeacherResponse>> Handle(GetAllTeacherRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<GetAllTeacherResponse>>(await _unitOfWork.Teacher.GetAll());
        }
    }
}
