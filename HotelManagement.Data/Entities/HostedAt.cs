namespace HotelManagement.Data.Entities
{
    public class HostedAt
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }

        public Invoice Invoice { get; set; }
        public Customer Customer { get; set; }
    }
}