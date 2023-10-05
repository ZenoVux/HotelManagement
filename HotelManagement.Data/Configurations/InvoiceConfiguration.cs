using HotelManagement.Data.Entities;
using HotelManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.RoomPrice).IsRequired();
            builder.Property(x => x.CheckinDate).IsRequired();
            builder.Property(x => x.CheckoutDate).IsRequired();
            builder.Property(x => x.RoomTotal).HasDefaultValue(0);
            builder.Property(x => x.ServiceTotal).HasDefaultValue(0);
            builder.Property(x => x.Tax).HasDefaultValue(0);
            builder.Property(x => x.Discount).HasDefaultValue(0);
            builder.Property(x => x.Total).HasDefaultValue(0);
            builder.Property(x => x.Status).HasDefaultValue(InvoiceStatus.PENDING);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Room)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.RoomId);
            builder.HasOne(x => x.Booking)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.BookingId);
        }
    }
}
