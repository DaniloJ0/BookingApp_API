namespace BookingApp.Domain.Models.Reservations
{
    public interface IReservationRepository
    {
        void Add(Reservation user);
        Task<List<Reservation>> GetAllAsync();
        Task<Reservation> GetByIdAsync(ReservationId id);
    }
}
