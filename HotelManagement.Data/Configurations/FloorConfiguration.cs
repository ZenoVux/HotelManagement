using HotelManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class FloorConfiguration : IEntityTypeConfiguration<Floor>
    {
        public void Configure(EntityTypeBuilder<Floor> builder)
        {
            builder.ToTable("Floors");
            builder.HasKey(x => x.Id);
            builder.Property(x =>  x.Id).UseIdentityColumn();
            builder.Property(x =>  x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
