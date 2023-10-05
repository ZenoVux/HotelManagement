using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string PeopleId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string FrontCardImagePath { get; set; }
        public string BackCardImagePath { get; set; }
        public CustomerType Type { get; set; }
        public CustomerStatus Status { get; set; }

        public List<HostedAt> HostedAts { get; set; }
    }
}
