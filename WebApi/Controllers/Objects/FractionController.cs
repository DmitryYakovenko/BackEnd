using Application.Commands.Objects.Fraction.CreateFraction;
using Application.Queries.Objects.Fractions.GetFractionsList;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Objects.Fraction;

namespace WebApi.Controllers.Objects
{
    [ApiController]
    [Route("[controller]")]
    public class FractionController : BaseController
    {
        private readonly IMapper _mapper;
        public FractionController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<FractionsListVM>> GetAll()
        {
            var query = new GetFractionsListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateFractionDTO Dto)
        {
            var command = _mapper.Map<CreateFractionCommand>(Dto);
            var a = await Mediator.Send(command);
            return Ok(a);
        }
    }
}
