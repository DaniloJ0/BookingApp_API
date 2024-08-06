using BookingApp.Domain.Models.Users;

namespace BookingApp.Domain.Models.DefaultRoles
{
    public class Role
    {
        public Role() { }
        public Role(RoleId id, string name, string nameEnglish)
        {
            Id = id;
            Name = name;
            NameEnglish = nameEnglish;
        }
        public RoleId Id { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public List<User> Users { get; set; }
    }
}
