using BookingApp.Domain.Models.DefaultRoomTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Infrastructure.Configurations
{
    internal class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new RoomTypeId(value));

            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.NameEnglish).IsRequired();

            builder.HasData(
            new RoomType { Id = new RoomTypeId(1), Name = "Unico", NameEnglish = "Single" },
            new RoomType { Id = new RoomTypeId(2), Name = "Doble", NameEnglish = "Double" },
            new RoomType { Id = new RoomTypeId(3), Name = "Suite", NameEnglish = "Suite" }
            );



        }
    }
}
