using System.Threading.Tasks;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub;
using Microsoft.AspNetCore.Mvc;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub;
using MediatR;

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
            GetByIdCategorySubResponse response = await _mediator.Send(new GetByIdCategorySubRequest {Id = id});
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategorySubRequest request)
        {
            return Ok(await _mediator.Send(request));
        }



    }
}
