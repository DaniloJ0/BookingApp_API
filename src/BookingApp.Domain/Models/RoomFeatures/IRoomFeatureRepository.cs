namespace BookingApp.Domain.Models.RoomFeatures
{
    public interface IRoomFeatureRepository
    {
        void Add(RoomFeature room);
        Task<List<RoomFeature>> GetAllAsync();
        Task<RoomFeature> GetByIdAsync(RoomFeatureId id);
    }
}
