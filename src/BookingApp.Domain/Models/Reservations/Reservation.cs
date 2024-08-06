using BookingApp.Domain.Models.Rooms;
using BookingApp.Domain.Models.Users;

namespace BookingApp.Domain.Models.Reservations
{
    public class Reservation
    {
        public Reservation() { }
        public Reservation(ReservationId id, DateTime checkIn, DateTime checkOut, decimal totalCost, int status, UserId userId, RoomId roomId, Room room)
        {
            Id = id;
            CheckIn = checkIn;
            CheckOut = checkOut;
            TotalCost = totalCost;
            Status = status;
            UserId = userId;
            RoomId = roomId;
            Room = room;
        }
        public ReservationId Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalCost { get; set; }
        public int Status { get; set; } // e.g., "Pending" => 0, "Confirmed" => 1, "Cancelled" => 2
        public User User { get; set; }
        public UserId UserId { get; set; }
        public RoomId RoomId { get; set; }
        public Room Room { get; set; }
    }
}
