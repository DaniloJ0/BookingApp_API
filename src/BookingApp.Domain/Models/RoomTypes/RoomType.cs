using BookingApp.Domain.Models.Users;

namespace BookingApp.Domain.Models.DefaultRoomTypes
{
    public class RoomType
    {
        public RoomType() { }
        public RoomType(RoomTypeId id, string name)
        {
            Id = id;
            Name = name;
        }
        public RoomTypeId Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
