namespace HotelManagement.Data.Entities 
{
    public class Floor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Room> Rooms { get; set; }
    }
}