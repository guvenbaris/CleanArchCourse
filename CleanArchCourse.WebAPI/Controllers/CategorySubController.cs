using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.DeleteCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.UpdateCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub;


namespace CleanArchCourse.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorySubController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategorySubController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           return Ok(await _mediator.Send(new GetAllCategorySubRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
           
            return Ok(await _mediator.Send(new GetByIdCategorySubRequest { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategorySubRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategorySubRequest request)
        {
            return Ok(await _mediator.Send(request));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteCategorySubRequest {Id = id}));
        }
        
    }
}
