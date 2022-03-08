using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;
using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher
{
    public class CreateTeacherCommand : IRequestHandler<CreateTeacherRequest,CreateTeacherResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTeacherCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateTeacherResponse> Handle(CreateTeacherRequest request, CancellationToken cancellationToken)
        {
            var teacher = _mapper.Map<Teacher>(request);

            teacher.Star = 0.0f;
            teacher.StudentCount = 0;
            teacher.IsDeleted = false;

            await _unitOfWork.Teacher.Add(teacher);

            await _unitOfWork.SaveChanges();

            return (new CreateTeacherResponse { Message = "Teacher created" });
        }
    }
}


