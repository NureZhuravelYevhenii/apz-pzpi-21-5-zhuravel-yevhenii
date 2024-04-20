using DataAccessLayer.Entities.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    [CollectionName("sensors")]
    public class Sensor : ICloneable
    {
        [Key]
        [BsonId]
        public Guid Id { get; set; }
        public Guid AnimalId { get; set; }
        public Guid TypeId { get; set; }
        public Guid AnimalCenterId { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
