using Application.Common.Exceptions;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Document.DryerDocument.StartDryerDocument
{
    public class StartDryerDocumentHandler : IRequestHandler<StartDryerDocumentCommand, bool>
    {
        private readonly IBaseDbContext _dbContext;
        public StartDryerDocumentHandler(IBaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(StartDryerDocumentCommand request, CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.DryerDocuments.FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException();
            }

            entity.StartWork = request.Start;
            entity.Temperature = request.Temperature;
            entity.Humidity = request.Humidity;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
