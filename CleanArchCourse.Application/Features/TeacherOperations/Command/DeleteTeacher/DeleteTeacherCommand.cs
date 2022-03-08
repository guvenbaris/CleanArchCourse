using System.Threading;
using System.Threading.Tasks;
using CleanArchCourse.Application.Exceptions;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;
using MediatR;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.DeleteTeacher
{
    public class DeleteTeacherCommand :IRequestHandler<DeleteTeacherRequest,DeleteTeacherReponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTeacherCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteTeacherReponse> Handle(DeleteTeacherRequest request, CancellationToken cancellationToken)
        {
            var teacher = _unitOfWork.Teacher.GetById(request.Id);

            if (teacher is null)
            {
                throw new NotFoundExceptions(nameof(Teacher), request.Id);
            }

            await _unitOfWork.Teacher.Delete(teacher.Result);
            await _unitOfWork.SaveChanges();

            return new DeleteTeacherReponse { Messages = "Teacher deleted" };
        }
    }
}
