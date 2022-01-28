using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetAllCategorySub;
using CleanArchCourse.Application.Features.CategorySubOperetions.Queries.GetByIdCategorySub;
using CleanArchCourse.Application.Interfaces.UnitOfWorks;

namespace CleanArchCourse.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorySubController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategorySubController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllCategorySubQuery(_unitOfWork);
            return Ok(await query.Handle());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var query = new GetByIdCategorySubQuery(_unitOfWork);

            return Ok(query.Handle(id).Result);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategorySubRequest request)
        {
            var command = new CreateCategorySubCommand(_unitOfWork,_mapper);
         
            return Ok(await command.Handle(request));
        }
    }
}
