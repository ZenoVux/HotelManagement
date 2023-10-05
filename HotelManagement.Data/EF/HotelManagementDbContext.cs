using HotelManagement.Data.Configurations;
using HotelManagement.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Data.Entities
{
    public class HotelManagementDbContext : IdentityDbContext<User, Role, Guid>
    {
        public HotelManagementDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BedInRoomConfiguration());
            modelBuilder.ApplyConfiguration(new BedTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new BookingDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new FloorConfiguration());
            modelBuilder.ApplyConfiguration(new HostedAtConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomImageConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new UsedServiceConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .ToTable("UserRoles")
                .HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserClaim<Guid>>()
                .ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<Guid>>()
                .ToTable("UserLogins")
                .HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>()
                .ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>()
                .ToTable("UserTokens")
                .HasKey(x => x.UserId);

            modelBuilder.Seed();
        }

        public DbSet<BedInRoom> BedInRooms { get; set; }
        public DbSet<BedType> BedTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<HostedAt> HostedAts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<UsedService> UsedServices { get; set; }
        public DbSet<User> Users { get; set; }
    }
}