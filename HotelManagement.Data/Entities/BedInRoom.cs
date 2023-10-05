namespace HotelManagement.Data.Entities
{
    public class BedInRoom
    {
        public int BedTypeId { get; set; }
        public int RoomTypeId { get; set; }
        public int Quantity { get; set; }

        public BedType BedType { get; set; }
        public RoomType RoomType { get; set; }
    }
}