namespace Domain.Documents
{
    public class BaseDocument
    {
        public int Id { get; set; }
        public DateTime CreateDete { get; set; }
        public int UserId { get; set; }
        public DateTime? StartWork { get; set; }
        public DateTime? EndWork { get; set; }
    }
}
