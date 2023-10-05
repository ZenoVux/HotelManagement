using HotelManagement.Data.Entities;
using HotelManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(RoomStatus.USING);

            builder.HasOne(x => x.Floor)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.FloorId);
            builder.HasOne(x => x.RoomType)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.RoomTypeId);
        }
    }
}
