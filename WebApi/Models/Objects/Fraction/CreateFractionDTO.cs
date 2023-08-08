using Application.Commands.Objects.Fraction.CreateFraction;
using Application.Common.Mappings;
using AutoMapper;

namespace WebApi.Models.Objects.Fraction
{
    public class CreateFractionDTO : IMapWith<CreateFractionCommand>
    {
        public int Density { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateFractionDTO, CreateFractionCommand>()
                .ForMember(Command => Command.Density, opt => opt.MapFrom(Dto => Dto.Density));

        }
    }
}
