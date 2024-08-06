using BookingApp.Domain.Models.DefaultRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BookingApp.Infrastructure.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new RoleId(value));

            builder.HasData(
            new Role { Id = new RoleId(1), Name = "Administrador", NameEnglish= "Admin"},
            new Role { Id = new RoleId(2), Name = "Cliente", NameEnglish="Customer" }
            );
        }
    }
}
