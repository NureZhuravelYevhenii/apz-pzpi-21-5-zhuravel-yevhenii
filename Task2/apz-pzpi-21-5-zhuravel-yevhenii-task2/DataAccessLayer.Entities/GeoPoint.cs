using MongoDB.Bson.Serialization.Attributes;

namespace DataAccessLayer.Entities
{
    public class GeoPoint
    {
        [BsonElement("coordinates")]
        public ICollection<double> Coordinates { get; set; } = new List<double>();

        [BsonElement("type")]
        public string Type { get; set; } = "Point";
    }
}
