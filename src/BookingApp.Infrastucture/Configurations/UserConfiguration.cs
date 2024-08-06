using BookingApp.Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BookingApp.Infrastructure.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new UserId(value));

            builder.Property(u => u.Email).HasMaxLength(50).IsRequired();
            builder.Property(u => u.PasswordHash).HasMaxLength(50).IsRequired();
            builder.Property(u => u.PhoneNumber).HasMaxLength(15);

            builder
            .HasMany(u => u.Reservations)
            .WithOne(r => r.User)
            .HasForeignKey(r => r.UserId);

            //builder.HasMany(u => u.Reviews)
            //.WithOne(r => r.User)
            //.HasForeignKey(r => r.UserId);
        }
    }
}
