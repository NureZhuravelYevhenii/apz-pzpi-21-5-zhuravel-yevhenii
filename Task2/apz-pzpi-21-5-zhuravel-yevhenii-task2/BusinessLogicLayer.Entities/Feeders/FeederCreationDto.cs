using DataAccessLayer.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Entities.Feeders
{
    public class FeederCreationDto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public GeoPoint Location { get; set; } = null!;
        public Guid AnimalCenterId { get; set; }
    }
}
