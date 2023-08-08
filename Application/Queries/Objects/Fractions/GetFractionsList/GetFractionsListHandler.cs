using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Objects.Fractions.GetFractionsList
{
    public class GetFractionsListHandler : IRequestHandler<GetFractionsListQuery, FractionsListVM>
    {
        private readonly IBaseDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetFractionsListHandler(IBaseDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<FractionsListVM> Handle(GetFractionsListQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.Fractions
                .ProjectTo<FractionListDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new FractionsListVM { Fractions = list };
        }
    }
}
