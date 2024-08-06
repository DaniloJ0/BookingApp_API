namespace BookingApp.Domain.Models.Features
{
    public interface IFeatureRepository
    {
        void Add(Feature room);
        Task<List<Feature>> GetAllAsync();
        Task<Feature> GetByIdAsync(FeatureId id);
    }
}
