namespace HotelManagement.Data.Entities
{
    public class RoomImage
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }

        public RoomType RoomType { get; set; }
    }
}
