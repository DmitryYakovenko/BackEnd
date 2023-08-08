using MediatR;

namespace Application.Commands.Document.DryerDocument.EndDryerDocument
{
    public class EndDryerDocumentCommand : IRequest<bool>
    {
        public DateTime End { get; set; }
    }
}
