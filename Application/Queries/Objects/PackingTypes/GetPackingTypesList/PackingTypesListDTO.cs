using Application.Common.Mappings;
using AutoMapper;
using Domain.Objects;

namespace Application.Queries.Objects.PackingTypes.GetPackingTypesList
{
    public class PackingTypesListDTO : IMapWith<PackingType>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PackingType, PackingTypesListDTO>()
                .ForMember(Dto => Dto.Id, opt => opt.MapFrom(obj => obj.Id))
                .ForMember(Dto => Dto.Name, opt => opt.MapFrom(obj => obj.Name));
        }
    }
}
