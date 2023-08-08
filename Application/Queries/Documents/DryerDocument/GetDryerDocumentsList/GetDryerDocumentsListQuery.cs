using Application.Queries.Objects.PackingTypes.GetPackingTypesList;
using MediatR;

namespace Application.Queries.Documents.DryerDocument.GetDryerDocumentsList
{
    public class GetDryerDocumentsListQuery : IRequest<DryerDocumentsListVM>
    {
    }
}
