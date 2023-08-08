using Application.Commands.Document.DryerDocument.CreateDryerDocument;
using Application.Commands.Document.DryerDocument.EndDryerDocument;
using Application.Commands.Document.DryerDocument.StartDryerDocument;
using Application.Queries.Documents.DryerDocument.GetDryerDocumentsList;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Documents.DryerDocument;

namespace WebApi.Controllers.Documents
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DryerDocumentController : BaseController
    {
        private readonly IMapper _mapper;
        public DryerDocumentController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<DryerDocumentsListVM>> GetAll()
        {
            var query = new GetDryerDocumentsListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create()
        {
            var command = new CreateDryerDocumentCommand();
            var a = await Mediator.Send(command);
            return Ok(a);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Start([FromBody] StartDryerDocumentDTO Dto)
        {
            var command = _mapper.Map<StartDryerDocumentCommand>(Dto);
            var a = await Mediator.Send(command);
            return Ok(a);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> End([FromBody] EndDryerDocumentDTO Dto)
        {
            var command = _mapper.Map<EndDryerDocumentCommand>(Dto);
            var a = await Mediator.Send(command);
            return Ok(a);
        }
    }
}
