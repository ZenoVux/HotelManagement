using HotelManagement.Data.Entities;
using HotelManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(x => x.PeopleId).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FrontCardImagePath).IsRequired();
            builder.Property(x => x.BackCardImagePath).IsRequired();
            builder.Property(x => x.Gender).HasDefaultValue(Gender.MALE);
            builder.Property(x => x.Type).HasDefaultValue(CustomerType.BRONZE);
            builder.Property(x => x.Status).HasDefaultValue(CustomerStatus.AVAILABLE);
        }
    }
}
