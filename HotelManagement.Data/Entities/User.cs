using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}
