using HotelManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class HostedAtConfiguration : IEntityTypeConfiguration<HostedAt>
    {
        public void Configure(EntityTypeBuilder<HostedAt> builder)
        {
            builder.ToTable("HostedAts");
            builder.HasKey(x => new { x.InvoiceId, x.CustomerId });

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.HostedAts)
                .HasForeignKey(x => x.InvoiceId);
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.HostedAts)
                .HasForeignKey(x => x.CustomerId);
        }
    }
}
