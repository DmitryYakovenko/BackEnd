using Application.Interfaces;
using Application.Queries.Objects.PackingTypes.GetPackingTypesList;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Documents.DryerDocument.GetDryerDocumentsList
{
    public class GetDryerDocumentsListHandler : IRequestHandler<GetDryerDocumentsListQuery, DryerDocumentsListVM>
    {
        private readonly IBaseDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetDryerDocumentsListHandler(IBaseDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<DryerDocumentsListVM> Handle(GetDryerDocumentsListQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.DryerDocuments
                .ProjectTo<DryerDocumentsListDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new DryerDocumentsListVM { DryerDocuments = list, Count = list.Count() };
        }
    }
}
