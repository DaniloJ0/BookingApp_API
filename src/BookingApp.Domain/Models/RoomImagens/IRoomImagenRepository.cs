using BookingApp.Domain.Models.Rooms;

namespace BookingApp.Domain.Models.RoomImages
{
    public interface IRoomImageRepository
    {
        void Add(RoomImage room);
        Task<List<RoomImage>> GetAllAsync();
        Task<RoomImage> GetByIdAsync(RoomImageId id);
    }
}
