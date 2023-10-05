using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumAdults { get; set; }
        public int NumChilds { get; set; }
        public DateTime CheckinExpected { get; set; }
        public DateTime CheckoutExpected { get; set; }
        public string Note { get; set; }
        public BookingStatus Status { get; set; }

        public List<BookingDetail> BookingDetails { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
