using Application.Commands.Objects.PackingType.CreatePackingType;
using Application.Queries.Objects.PackingTypes.GetPackingTypesList;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Objects.PackingType;

namespace WebApi.Controllers.Objects
{
    [ApiController]
    [Route("[controller]")]
    public class PackingTypeController : BaseController
    {
        private readonly IMapper _mapper;
        public PackingTypeController(IMapper mapper) => _mapper = mapper;


        [HttpGet]
        public async Task<ActionResult<PackingTypesListVM>> GetAll()
        {
            var query = new GetPackingTypesListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreatePackingTypeDTO createDto)
        {
            var command = _mapper.Map<CreatePackingTypeCommand>(createDto);
            var a = await Mediator.Send(command);
            return Ok(a);
        }
    }
}
