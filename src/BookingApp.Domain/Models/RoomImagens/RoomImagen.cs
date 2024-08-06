using BookingApp.Domain.Models.DefaultRoomTypes;
using BookingApp.Domain.Models.Reservations;
using BookingApp.Domain.Models.RoomImages;

namespace BookingApp.Domain.Models.Rooms
{
    public class RoomImage
    {
        public RoomImage() { }
        public RoomImage(RoomImageId id, string url, RoomId roomId, Room room)
        {
            Id = id;
            Url = url;
            RoomId = roomId;
            Room = room;
        }
        public RoomImageId Id { get; set; }
        public string Url { get; set; }
        public RoomId RoomId { get; set; }
        public Room Room { get; set; }
    }
}
