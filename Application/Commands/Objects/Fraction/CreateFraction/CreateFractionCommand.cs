using MediatR;

namespace Application.Commands.Objects.Fraction.CreateFraction
{
    public class CreateFractionCommand : IRequest<int>
    {
        public int Density { get; set; }
    }
}
