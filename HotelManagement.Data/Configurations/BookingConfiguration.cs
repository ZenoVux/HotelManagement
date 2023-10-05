using HotelManagement.Data.Entities;
using HotelManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.NumAdults).IsRequired();
            builder.Property(x => x.NumChilds).IsRequired();
            builder.Property(x => x.CheckinExpected).IsRequired();
            builder.Property(x => x.CheckoutExpected).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(BookingStatus.PENDING);
        }
    }
}
