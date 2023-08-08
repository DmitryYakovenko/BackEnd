using Application.Interfaces;
using MediatR;

namespace Application.Commands.Objects.Fraction.CreateFraction
{
    public class CreateFractionHandler : IRequestHandler<CreateFractionCommand, int>
    {
        private readonly IBaseDbContext _dbContext;
        public CreateFractionHandler(IBaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateFractionCommand request, CancellationToken cancellationToken)
        {
            int Id = 0;
            if (_dbContext.Fractions.Count() != 0)
            {
                Id = _dbContext.Fractions.Max(x => x.Id) + 1;
            }

            var obj = new Domain.Objects.Fraction()
            {
                Id = Id,
                Name = "ρ" + request.Density.ToString(),
                Density = request.Density
            };

            await _dbContext.Fractions.AddAsync(obj, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return obj.Id;
        }
    }
}
