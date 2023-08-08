namespace Domain.Documents
{
    public class ShippingDocument : BaseDocument
    {
        public string Buyer { get; set; }
        public string TransportNumber { get; set; }
    }
}
