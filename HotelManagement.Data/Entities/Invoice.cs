using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int RoomId { get; set; }
        public int BookingId { get; set; }
        public decimal RoomPrice { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public decimal RoomTotal { get; set; }
        public decimal ServiceTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string Note { get; set; }
        public InvoiceStatus Status { get; set; }

        public User User { get; set; }
        public Room Room { get; set; }
        public Booking Booking { get; set; }
        public List<HostedAt> HostedAts { get; set; }
        public List<UsedService> UsedServices { get; set; }
    }
}