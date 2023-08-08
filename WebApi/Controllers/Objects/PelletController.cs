/*using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Objects
{
    [ApiController]
    [Route("[controller]")]
    public class PelletController : BaseController
    {
        private readonly IMapper _mapper;
        public PelletController(IMapper mapper) => _mapper = mapper;

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<int>> Create([FromBody] CreatePelletDto createDto)
        {

            var command = _mapper.Map<CreatePelletCommand>(createDto);
            var a = await Mediator.Send(command);
            return Ok(a);
        }
    }
}
*/