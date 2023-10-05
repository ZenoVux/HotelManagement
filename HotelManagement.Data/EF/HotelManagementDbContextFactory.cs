using HotelManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HotelManagement.Data.EF
{
    public class HotelManagementDbContextFactory : IDesignTimeDbContextFactory<HotelManagementDbContext>
    {
        public HotelManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HotelManagementDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-KG0QKNR;Database=HotelManagement;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            return new HotelManagementDbContext(optionsBuilder.Options);
        }
    }
}
