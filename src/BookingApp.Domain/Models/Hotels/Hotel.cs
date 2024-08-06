using BookingApp.Domain.Models.Rooms;

namespace BookingApp.Domain.Models.Hotels
{
    public class Hotel
    {
        public Hotel() { }
        public Hotel(HotelId id, string name, string nameEnglish, string address, string city, string state, string country, string phoneNumber, string email, string description)
        {
            Id = id;
            Name = name;
            NameEnglish = nameEnglish;
            Address = address;
            City = city;
            State = state;
            Country = country;
            PhoneNumber = phoneNumber;
            Email = email;
            Description = description;
        }

        public HotelId Id { get; set; } 
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
