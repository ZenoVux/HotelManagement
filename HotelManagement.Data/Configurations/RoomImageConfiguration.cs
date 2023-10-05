using HotelManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class RoomImageConfiguration : IEntityTypeConfiguration<RoomImage>
    {
        public void Configure(EntityTypeBuilder<RoomImage> builder)
        {
            builder.ToTable("RoomImages");
            builder.HasKey(x =>  x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ImagePath).IsRequired();
            builder.Property(x => x.IsDefault).HasDefaultValue(true);
            builder.Property(x => x.SortOrder).IsRequired();

            builder.HasOne(x => x.RoomType)
                .WithMany(x => x.RoomImages)
                .HasForeignKey(x => x.RoomTypeId);
        }
    }
}
