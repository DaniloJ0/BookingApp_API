using BookingApp.Domain.Models.Rooms;

namespace BookingApp.Domain.Models.DefaultRoomTypes
{
    public class RoomType
    {
        public RoomType() { }
        public RoomType(RoomTypeId id, string name, string nameEnglish)
        {
            Id = id;
            Name = name;
            NameEnglish = nameEnglish;
        }
        public RoomTypeId Id { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public List<Room> Rooms{ get; set; }

    }
}
