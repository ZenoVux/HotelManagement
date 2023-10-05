using HotelManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class BedInRoomConfiguration : IEntityTypeConfiguration<BedInRoom>
    {
        public void Configure(EntityTypeBuilder<BedInRoom> builder)
        {
            builder.ToTable("BedInRooms");
            builder.HasKey(x => new { x.RoomTypeId, x.BedTypeId });
            builder.Property(x => x.Quantity).IsRequired();

            builder.HasOne(x => x.BedType)
                .WithMany(x => x.BedInRooms)
                .HasForeignKey(x => x.BedTypeId);
            builder.HasOne(x => x.RoomType)
                .WithMany(x => x.BedInRooms)
                .HasForeignKey(x => x.RoomTypeId);
        }
    }
}
