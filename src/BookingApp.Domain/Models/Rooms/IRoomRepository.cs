namespace BookingApp.Domain.Models.Rooms
{
    public interface IRoomRepository
    {
        void Add(Room room);
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(RoomId id);
    }
}
