namespace BookingApp.Domain.Models.Hotels
{
    public interface IHotelRepository
    {
        void Add(Hotel room);
        Task<List<Hotel>> GetAllAsync();
        Task<Hotel> GetByIdAsync(HotelId id);
    }
}
