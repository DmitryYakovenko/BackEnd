using Application.Commands.Document.DryerDocument.StartDryerDocument;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Document.DryerDocument.EndDryerDocument
{
    public class EndDryerDocumentHandler : IRequestHandler<EndDryerDocumentCommand, bool>
    {
        private readonly IBaseDbContext _dbContext;
        public EndDryerDocumentHandler(IBaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(EndDryerDocumentCommand request, CancellationToken cancellationToken)
        {
            var doc = _dbContext.DryerDocuments.Last();
            doc.EndWork = request.End;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
