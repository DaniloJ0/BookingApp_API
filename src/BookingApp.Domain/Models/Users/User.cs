using BookingApp.Domain.Models.DefaultRoles;
using BookingApp.Domain.Models.Reservations;

namespace BookingApp.Domain.Models.Users
{
    public class User
    {
        public User() { }
        public User(UserId id, string name, string email, string passwordHash, RoleId role, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
            PhoneNumber = phoneNumber;
        }
        public UserId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public RoleId Role { get; set; } // "Admin", "Customer"
        public string PhoneNumber { get; set; } 
        public ICollection<Reservation> Reservations { get; set; }
    }
}
