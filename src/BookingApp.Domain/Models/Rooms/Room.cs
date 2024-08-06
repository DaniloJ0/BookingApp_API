using BookingApp.Domain.Models.DefaultRoomTypes;
using BookingApp.Domain.Models.Hotels;
using BookingApp.Domain.Models.Reservations;
using BookingApp.Domain.Models.RoomFeatures;

namespace BookingApp.Domain.Models.Rooms
{
    public class Room
    {
        public Room() { }
        public Room(RoomId id, string name, string number, string description, decimal pricePerNight, bool isAvailable, RoomTypeId roomTypeId)
        {
            Id = id;
            Name = name;
            Number = number;
            Description = description;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
            RoomTypeId = roomTypeId;
        }
        public RoomId Id { get; set; }
        public HotelId HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string Name { get; set; }
        public string Number { get; set; } // e.g., "101", "202"
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public RoomType RoomType { get; set; }
        public RoomTypeId RoomTypeId { get; set; } // e.g., "Single", "Double", "Suite"
        public List<RoomFeature> RoomFeatures { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<RoomImage> Images { get; set; } // Room images
    }
}
