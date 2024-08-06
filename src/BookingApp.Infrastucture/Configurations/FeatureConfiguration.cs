using BookingApp.Domain.Models.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Infrastructure.Configurations
{
    internal class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasData(
            new Feature { Id = new FeatureId(1), Name = "Aire Acondicionado" ,NameEnglish = "Air Conditioning" },
            new Feature { Id = new FeatureId(2), Name = "Balcon" ,NameEnglish = "Balcony" },
            new Feature { Id = new FeatureId(3), Name = "Piscina" ,NameEnglish = "Pool" },
            new Feature { Id = new FeatureId(4), Name = "Abanico" ,NameEnglish = "Fan" },
            new Feature { Id = new FeatureId(5), Name = "Tv" ,NameEnglish = "Fan" }
        );

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new FeatureId(value));

            builder.Property(u => u.Name).HasMaxLength(50).IsRequired();
            builder.Property(u => u.NameEnglish).HasMaxLength(50);

            builder.HasMany(u => u.RoomFeatures)
                .WithOne(u => u.Feature)
                .HasForeignKey(u => u.FeatureId);

        }
    }
}
