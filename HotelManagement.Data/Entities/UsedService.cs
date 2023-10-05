namespace HotelManagement.Data.Entities
{
    public class UsedService
    {
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public decimal ServicePrice { get; set; }
        public DateTime UsedDate { get; set; }

        public Invoice Invoice { get; set; }
        public Service Service { get; set; }
    }
}