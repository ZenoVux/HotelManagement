namespace HotelManagement.Data.Entities
{
    public class BedType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<BedInRoom> BedInRooms { get; set; }
    }
}