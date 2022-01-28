using System.Threading.Tasks;
using CleanArchCourse.Application.Exceptions;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.UpdateTeacher
{
    public class UpdateTeacherCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateTeacherCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateTeacherResponse> Handle(UpdateTeacherRequest request,int id)
        {

            var teacher = _unitOfWork.Teacher.GetById(id).Result;
            if (teacher is null)
            {
                throw new NotFoundExceptions(nameof(Teacher), id);
            }

            teacher.Name = teacher.Name != default ? request.Name : teacher.Name;
            teacher.Surname = teacher.Surname != default ? request.Surname : teacher.Surname;
            teacher.IsDeleted = request.IsDeleted;

            await _unitOfWork.Teacher.Update(teacher);
            await _unitOfWork.SaveChanges();

            return new UpdateTeacherResponse {Messages = "Teacher updated", Success = true};

        }
    }
}
