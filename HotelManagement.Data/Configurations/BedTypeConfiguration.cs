using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.Entities
{
    public class BedTypeConfiguration : IEntityTypeConfiguration<BedType>
    {
        public void Configure(EntityTypeBuilder<BedType> builder)
        {
            builder.ToTable("BedTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}