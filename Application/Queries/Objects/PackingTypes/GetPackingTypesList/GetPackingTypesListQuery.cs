using MediatR;

namespace Application.Queries.Objects.PackingTypes.GetPackingTypesList
{
    public class GetPackingTypesListQuery : IRequest<PackingTypesListVM>
    {
    }
}
