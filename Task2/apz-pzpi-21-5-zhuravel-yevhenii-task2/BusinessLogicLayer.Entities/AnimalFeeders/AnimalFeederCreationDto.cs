using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Entities.AnimalFeeders
{
    public class AnimalFeederCreationDto
    {
        [Key]
        public Guid AnimalId { get; set; }
        [Key]
        public Guid FeederId { get; set; }
        public double AmountOfFood { get; set; }
        public DateTime FeedDate { get; set; }
    }
}
