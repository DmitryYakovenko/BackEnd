using MediatR;

namespace Application.Commands.Document.DryerDocument.StartDryerDocument
{
    public class StartDryerDocumentCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public int Humidity { get; set; }
        public int Temperature { get; set; }
    }
}
