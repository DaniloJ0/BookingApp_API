using BookingApp.Domain.Models.Rooms;
using BookingApp.Domain.Models.Users;

namespace BookingApp.Domain.Models.Reservations
{
    public class Reservation
    {
        public Reservation() { }
        public Reservation(ReservationId id, DateTime startDate, DateTime endDate, decimal totalCost, string status, Guid reservationId, User user, Guid roomId, Room room)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            TotalCost = totalCost;
            Status = status;
            ReservationId = reservationId;
            User = user;
            RoomId = roomId;
            Room = room;
        }
        public ReservationId Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; } // e.g., "Pending", "Confirmed", "Cancelled"
        public Guid ReservationId { get; set; }
        public User User { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
