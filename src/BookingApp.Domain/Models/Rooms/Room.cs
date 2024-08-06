using BookingApp.Domain.Models.DefaultRoomTypes;
using BookingApp.Domain.Models.Reservations;

namespace BookingApp.Domain.Models.Rooms
{
    public class Room
    {
        public Room() { }
        public Room(RoomId id, string name, string description, decimal pricePerNight, bool isAvailable, RoomType type)
        {
            Id = id;
            Name = name;
            Description = description;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
            Type = type;
        }
        public RoomId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public RoomType Type { get; set; } // e.g., "Single", "Double", "Suite"
        public List<Reservation> Reservations { get; set; }
    }
}
