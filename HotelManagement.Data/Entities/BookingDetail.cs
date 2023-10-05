using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entities
{
    public class BookingDetail
    {
        public int BookingId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal RoomPrice { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public BookingDetailStatus Status { get; set; }

        public Booking Booking { get; set; }
        public RoomType RoomType { get; set; }
    }
}
