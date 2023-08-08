using Application.Commands.Document.DryerDocument.StartDryerDocument;
using Application.Common.Mappings;
using AutoMapper;

namespace WebApi.Models.Documents.DryerDocument
{
    public class StartDryerDocumentDTO : IMapWith<StartDryerDocumentCommand>
    { 
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public int Humidity { get; set; }
        public int Temperature { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<StartDryerDocumentDTO, StartDryerDocumentCommand>()
                .ForMember(Command => Command.Id, opt => opt.MapFrom(Dto => Dto.Id))
                .ForMember(Command => Command.Start, opt => opt.MapFrom(Dto => Convert.ToDateTime(Dto.Start)))
                .ForMember(Command => Command.Humidity, opt => opt.MapFrom(Dto => Dto.Humidity))
                .ForMember(Command => Command.Temperature, opt => opt.MapFrom(Dto => Dto.Temperature));
        }
    }
}
