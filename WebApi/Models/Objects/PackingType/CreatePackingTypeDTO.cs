using Application.Commands.Objects.PackingType.CreatePackingType;
using Application.Common.Mappings;
using AutoMapper;

namespace WebApi.Models.Objects.PackingType
{
    public class CreatePackingTypeDTO : IMapWith<CreatePackingTypeCommand>
    {
        public string Name { get; set; }
        public int Mass { get; set; }
        public bool AvailableToMerge { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePackingTypeDTO, CreatePackingTypeCommand>()
                .ForMember(Command => Command.Name, opt => opt.MapFrom(Dto => Dto.Name))
                .ForMember(Command => Command.Mass, opt => opt.MapFrom(Dto => Dto.Mass))
                .ForMember(Command => Command.AvailableToMerge, opt => opt.MapFrom(Dto => Dto.AvailableToMerge));
        }
    }
}
