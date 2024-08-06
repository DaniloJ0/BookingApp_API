namespace BookingApp.Domain.Models.Users
{
    public interface IUserRepository
    {
        void Add(User user);
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(UserId id);
    }
}
