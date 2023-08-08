using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Objects.PackingTypes.GetPackingTypesList
{
    public class GetPackingTypesListHandler : IRequestHandler<GetPackingTypesListQuery, PackingTypesListVM>
    {
        private readonly IBaseDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetPackingTypesListHandler(IBaseDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<PackingTypesListVM> Handle(GetPackingTypesListQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.PackingTypes
                .ProjectTo<PackingTypesListDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new PackingTypesListVM { PackingTypes = list };
        }
    }
}
