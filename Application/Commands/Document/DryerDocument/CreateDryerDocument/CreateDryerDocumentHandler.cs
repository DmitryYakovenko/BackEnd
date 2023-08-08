using Application.Commands.Objects.PackingType.CreatePackingType;
using Application.Common.Exceptions;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Document.DryerDocument.CreateDryerDocument
{
    public class CreateDryerDocumentHandler : IRequestHandler<CreateDryerDocumentCommand, int>
    {
        private readonly IBaseDbContext _dbContext;
        public CreateDryerDocumentHandler(IBaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateDryerDocumentCommand request, CancellationToken cancellationToken)
        {
            if (!CheckingOpenDocuments())
            {
                throw new OpenDocumentException();
            }

            int Id = 0;
            if (_dbContext.DryerDocuments.Count() != 0)
            {
                Id = _dbContext.DryerDocuments.Max(x => x.Id) + 1;
            }

            var obj = new Domain.Documents.DryerDocument()
            {
                Id = Id,
                CreateDete = DateTime.Now
            };

            await _dbContext.DryerDocuments.AddAsync(obj, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return obj.Id;
        }

        bool CheckingOpenDocuments()
        {
            int Count = _dbContext.DryerDocuments.Where(d => d.EndWork == null).Count();
            return Count == 0;
        }
    }
}
