using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;

namespace CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher
{
     public class GetByIdTeacherQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdTeacherQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetByIdTeacherResponse> Handle(int id) =>
            _mapper.Map<GetByIdTeacherResponse>(await _unitOfWork.Teacher.GetById(id));
    }
}
