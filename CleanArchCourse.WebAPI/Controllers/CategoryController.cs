using System.Threading.Tasks;
using CleanArchCourse.Application.Features.CategoryOperations.Command.CreateCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Command.DeleteCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Command.UpdateCategory;
using Microsoft.AspNetCore.Mvc;
using CleanArchCourse.Application.Features.CategoryOperations.Queries.GetAllCategory;
using CleanArchCourse.Application.Features.CategoryOperations.Queries.GetByIdCategory;
using MediatR;

namespace CleanArchCourse.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllCategoryRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok(await _mediator.Send(new GetByIdCategoryRequest { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryRequest request)
        {
            return Ok(await _mediator.Send(request));

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteCategoryRequest { Id = id }));
        }

    }
}
