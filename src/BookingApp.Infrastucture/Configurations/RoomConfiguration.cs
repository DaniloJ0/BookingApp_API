using BookingApp.Domain.Models.Rooms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Infrastructure.Configurations
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new RoomId(value));

            builder.Property(u => u.Name).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Description).HasMaxLength(200).IsRequired();
            builder.Property(u => u.PricePerNight).HasMaxLength(50).IsRequired();
            builder.Property(u => u.IsAvailable).IsRequired();

            builder.HasMany(r => r.Reservations)
            .WithOne(r => r.Room)
            .HasForeignKey(r => r.RoomId);

            builder
            .HasMany(r => r.Images)
            .WithOne(i => i.Room)
            .HasForeignKey(i => i.RoomId);

            builder
            .HasOne(r => r.RoomType)
            .WithMany(rt => rt.Rooms)
            .HasForeignKey(r => r.RoomTypeId);

            builder
            .HasOne(r => r.Hotel)
            .WithMany(h => h.Rooms)
            .HasForeignKey(r => r.HotelId);

            //builder
            //.HasMany(r => r.Reviews)
            //.WithOne(rv => rv.Room)
            //.HasForeignKey(rv => rv.RoomId);
        }
    }
}
