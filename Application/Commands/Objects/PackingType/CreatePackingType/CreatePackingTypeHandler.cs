using Application.Interfaces;
using MediatR;

namespace Application.Commands.Objects.PackingType.CreatePackingType
{
    public class CreatePackingTypeHandler : IRequestHandler<CreatePackingTypeCommand, int>
    {
        private readonly IBaseDbContext _dbContext;
        public CreatePackingTypeHandler(IBaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreatePackingTypeCommand request, CancellationToken cancellationToken)
        {
            int Id = 0;
            if (_dbContext.PackingTypes.Count() != 0)
            {
                Id = _dbContext.PackingTypes.Max(x => x.Id) + 1;
            }

            var obj = new Domain.Objects.PackingType()
            {
                Id = Id,
                Name = request.Name,
                Mass = request.Mass,
                AvailableToMerge = request.AvailableToMerge
            };

            await _dbContext.PackingTypes.AddAsync(obj, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return obj.Id;
        }
    }
}
