using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class UnitOfMeasure
    {
        public Guid UnitOfMeasureId { get; set; }
        [Required]
        public string UnitOfMeasureName { get; set; }
        public string Description { get; set; }
    }
}
