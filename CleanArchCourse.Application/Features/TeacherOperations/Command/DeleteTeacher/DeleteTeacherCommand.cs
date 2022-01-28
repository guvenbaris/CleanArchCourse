using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchCourse.Application.Exceptions;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.DeleteTeacher
{
    public class DeleteTeacherCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTeacherCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteTeacherReponse> Handler(int id)
        {
            var teacher =  _unitOfWork.Teacher.GetById(id);

            if (teacher is null)
            {
                throw new NotFoundExceptions(nameof(Teacher), id);
            }

            await _unitOfWork.Teacher.Delete(teacher.Result);
            await _unitOfWork.SaveChanges();

            return new DeleteTeacherReponse {Messages = "Teacher deleted"};
        }


    }
}
