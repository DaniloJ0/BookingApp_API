using BookingApp.Domain.Models.RoomFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BookingApp.Infrastructure.Configurations
{
    internal class RoomFeatureConfiguration : IEntityTypeConfiguration<RoomFeature>
    {
        public void Configure(EntityTypeBuilder<RoomFeature> builder)
        {
            //builder.HasKey(u => u.Id);

            //builder.Property(u => u.Id).HasConversion(
            //userId => userId.Value,
            //    value => new RoomFeatureId(value));

            builder.HasKey(rf => new { rf.RoomId, rf.FeatureId });

            builder
               .HasOne(rf => rf.Room)
               .WithMany(r => r.RoomFeatures)
               .HasForeignKey(rf => rf.RoomId);

            builder    
                .HasOne(rf => rf.Feature)
                .WithMany(f => f.RoomFeatures)
                .HasForeignKey(rf => rf.FeatureId);
        }
    }
}
