using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;
using CleanArchCourse.Domain.Concrete.Entities;

namespace CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher
{
    public class CreateTeacherCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTeacherCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(Teacher teacher)
        {
            await _unitOfWork.Teacher.Add(teacher);
        }
    }
}
