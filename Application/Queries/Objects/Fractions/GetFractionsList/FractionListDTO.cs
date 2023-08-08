using Application.Common.Mappings;
using AutoMapper;
using Domain.Objects;

namespace Application.Queries.Objects.Fractions.GetFractionsList
{
    public class FractionListDTO : IMapWith<Fraction>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Fraction, FractionListDTO>()
                .ForMember(Dto => Dto.Id,   opt => opt.MapFrom(obj => obj.Id))
                .ForMember(Dto => Dto.Name, opt => opt.MapFrom(obj => obj.Name));
        }
    }
}
