using BookingApp.Domain.Models.Features;
using BookingApp.Domain.Models.Rooms;

namespace BookingApp.Domain.Models.RoomFeatures
{
    public class RoomFeature
    {
        public RoomFeature() { }
        public RoomFeature(RoomId roomId, FeatureId featureId)
        {
            RoomId = roomId;
            FeatureId = featureId;
        }
        public RoomId RoomId { get; set; }
        public Room Room { get; set; }
        public FeatureId FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
