using HotelManagement.Data.Entities;
using HotelManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.ToTable("BookingDetails");
            builder.HasKey(x => new { x.BookingId, x.RoomTypeId });
            builder.Property(x => x.RoomPrice).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(BookingDetailStatus.PENDING);

            builder.HasOne(x => x.Booking)
                .WithMany(x => x.BookingDetails)
                .HasForeignKey(x => x.BookingId);
            builder.HasOne(x => x.RoomType)
                .WithMany(x => x.BookingDetails)
                .HasForeignKey(x => x.RoomTypeId);  
        }
    }
}
