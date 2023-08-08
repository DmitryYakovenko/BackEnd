namespace Domain.Objects
{
    public class Pellet
    {
        public int Id { get; set; }
        public int PackagingTypeId { get; set; }
        public int FractionId { get; set; }
        public int Barcode { get; set; }
        public int Count { get; set; }
        public int PackingDocument { get; set; }
    }
}
