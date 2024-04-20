using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Entities.AnimalFeeders
{
    public class AnimalFeederUpdateDto
    {
        [Key]
        public Guid AnimalId { get; set; }
        [Key]
        public Guid FeederId { get; set; }
        public DateTime FeedDate { get; set; }
        public double AmountOfFood { get; set; }
    }
}
