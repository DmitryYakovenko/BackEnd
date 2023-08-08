

namespace Application.Queries.Documents.DryerDocument.GetDryerDocumentsList
{
    public class DryerDocumentsListVM
    {
        public IList<DryerDocumentsListDTO> DryerDocuments { get; set; }
        public int Count { get; set; }
    }
}
