using BookingApp.Domain.Models.Reservations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Infrastructure.Configurations
{
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new ReservationId(value));

            builder.Property(u => u.CheckIn).IsRequired();
            builder.Property(u => u.CheckOut).IsRequired();
            builder.Property(u => u.TotalCost).IsRequired();
            builder.Property(u => u.Status).IsRequired();
        }
    }
}
