using Application.Common.Mappings;
using AutoMapper;

namespace Application.Queries.Documents.DryerDocument.GetDryerDocumentsList
{
    public class DryerDocumentsListDTO : IMapWith<Domain.Documents.DryerDocument>
    {
        public int Id { get; set; }
        public DateTime? StartWork { get; set; }
        public DateTime? EndWork { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Documents.DryerDocument, DryerDocumentsListDTO>()
                .ForMember(Dto => Dto.Id, opt => opt.MapFrom(obj => obj.Id))
                .ForMember(Dto => Dto.StartWork, opt => opt.MapFrom(obj => obj.StartWork))
                .ForMember(Dto => Dto.EndWork, opt => opt.MapFrom(obj => obj.EndWork));
        }
    }
}
