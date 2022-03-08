using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher
{
     public class GetByIdTeacherQuery :IRequestHandler<GetByIdTeacherRequest,GetByIdTeacherResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdTeacherQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
 
        public async Task<GetByIdTeacherResponse> Handle(GetByIdTeacherRequest request, CancellationToken cancellationToken)
        {
           return _mapper.Map<GetByIdTeacherResponse>(await _unitOfWork.Teacher.GetById(request.Id));
        }
    }
}
