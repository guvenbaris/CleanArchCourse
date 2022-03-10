using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArchCourse.Application.Features.TeacherOperations.Command.CreateTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Command.DeleteTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Command.UpdateTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Queries.GetAllTeacher;
using CleanArchCourse.Application.Features.TeacherOperations.Queries.GetByIdTeacher;



namespace CleanArchCourse.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeacherController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllTeacherRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _mediator.Send(new GetByIdTeacherRequest {Id = id}));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTeacherRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTeacherRequest request)
        {
            return Ok(await _mediator.Send(request));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteTeacherRequest() { Id = id }));
        }
    }
}
