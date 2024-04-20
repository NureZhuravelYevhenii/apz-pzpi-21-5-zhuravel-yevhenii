using DataAccessLayer.Entities.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    [CollectionName("animals-feeders")]
    public class AnimalFeeder : ICloneable
    {
        public ObjectId Id { get; set; }

        [Key]
        public Guid AnimalId { get; set; }
        [Key]
        public Guid FeederId { get; set; }
        public double AmountOfFood { get; set; }

        private DateTime _feedDate;
        public DateTime FeedDate 
        {
            get => _feedDate.ToUniversalTime();
            set => _feedDate = value;
        }

        public Feeder Feeder { get; set; } = null!;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
