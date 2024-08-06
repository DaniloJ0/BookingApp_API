using BookingApp.Domain.Models.DefaultRoles;
using BookingApp.Domain.Models.DefaultRoomTypes;
using BookingApp.Domain.Models.Reservations;
using BookingApp.Domain.Models.Rooms;
using BookingApp.Domain.Models.Users;
using BookingApp.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace NumberToWords.Infrastructure
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<RoomType> RoomTypes{ get; set; }
        public DbSet<Role> Roles{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomImageConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
        }
    }
}
