namespace HotelManagement.Data.Entities
{
    public class RoomType
    {
        public int Id { get; set; }
        public double Area { get; set; }
        public decimal Price { get; set; }
        public bool IsSmoking { get; set; }
        public string CancellationPolicy { get; set; }
        public string OtherPolicy { get; set; }
        public string Description { get; set; }

        public List<Room> Rooms { get; set; }
        public List<RoomImage> RoomImages { get; set; }
        public List<BedInRoom> BedInRooms { get; set; }
        public List<BookingDetail> BookingDetails { get; set; }
    }
}
