using Application.Commands.Document.DryerDocument.EndDryerDocument;
using Application.Common.Mappings;
using AutoMapper;

namespace WebApi.Models.Documents.DryerDocument
{
    public class EndDryerDocumentDTO : IMapWith<EndDryerDocumentCommand>
    {
        public DateTime End { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EndDryerDocumentDTO, EndDryerDocumentCommand>()
                .ForMember(Command => Command.End, opt => opt.MapFrom(Dto => Dto.End));
        }
    }
}
