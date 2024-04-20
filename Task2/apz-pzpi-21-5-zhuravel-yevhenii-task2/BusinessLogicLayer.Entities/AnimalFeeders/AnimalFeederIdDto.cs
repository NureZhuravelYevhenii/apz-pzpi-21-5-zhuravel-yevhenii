using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Entities.AnimalFeeders
{
    public class AnimalFeederIdDto
    {
        [Key]
        public Guid AnimalId { get; set; }
        [Key]
        public Guid FeederId { get; set; }
    }
}
