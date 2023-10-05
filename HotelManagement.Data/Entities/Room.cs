using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int FloorId { get; set; }
        public int RoomTypeId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public RoomStatus Status { get; set; }

        public Floor Floor { get; set; }
        public RoomType RoomType { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
