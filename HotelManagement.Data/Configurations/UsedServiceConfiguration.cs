using HotelManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class UsedServiceConfiguration : IEntityTypeConfiguration<UsedService>
    {
        public void Configure(EntityTypeBuilder<UsedService> builder)
        {
            builder.ToTable("UsedServices");
            builder.HasKey(x => new { x.InvoiceId, x.ServiceId });
            builder.Property(x => x.ServicePrice).IsRequired();
            builder.Property(x => x.UsedDate).IsRequired();

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.UsedServices)
                .HasForeignKey(x => x.InvoiceId);
            builder.HasOne(x => x.Service)
                .WithMany(x => x.UsedServices)
                .HasForeignKey(x => x.ServiceId);
        }
    }
}
