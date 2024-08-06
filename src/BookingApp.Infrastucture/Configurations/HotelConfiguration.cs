using BookingApp.Domain.Models.Hotels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BookingApp.Infrastructure.Configurations
{
    internal class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {

            builder.HasData(
            new Hotel { Id = new HotelId(Guid.NewGuid()), Name = "Grand Hotel", Address = "123 Main St", City = "Santa Marta", State = "Magdalena", Country = "Colombia",PhoneNumber = "123-456-7890", Email = "info@grandhotel.com", Description = "A luxurious hotel in the heart of the city."}
            );

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new HotelId(value));

            builder.Property(u => u.Name).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Address).HasMaxLength(50).IsRequired();
            builder.Property(u => u.City).HasMaxLength(20).IsRequired();
            builder.Property(u => u.State).HasMaxLength(20).IsRequired();
            builder.Property(u => u.Country).HasMaxLength(20).IsRequired();
            builder.Property(u => u.PhoneNumber).HasMaxLength(15).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Description).HasMaxLength(200).IsRequired();
        }
    }
}
