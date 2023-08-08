using MediatR;

namespace Application.Commands.Objects.PackingType.CreatePackingType
{
    public class CreatePackingTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mass { get; set; }
        public bool AvailableToMerge { get; set; }
    }
}
