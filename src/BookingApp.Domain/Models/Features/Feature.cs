using BookingApp.Domain.Models.Reservations;
using BookingApp.Domain.Models.RoomFeatures;

namespace BookingApp.Domain.Models.Features
{
    public class Feature
    {
        public Feature() { }
        public Feature(FeatureId id, string name, string nameEnglish)
        {
            Id = id;
            Name = name;
            NameEnglish = nameEnglish;
        }
        public FeatureId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameEnglish { get; set; } = string.Empty;
        public List<RoomFeature> RoomFeatures { get; set; }
    }
}
