using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class NumberSequence
    {
        public Guid NumberSequenceId { get; set; }
        [Required]
        public string NumberSequenceName { get; set; }
        [Required]
        public string Module { get; set; }
        [Required]
        public string Prefix { get; set; }
        public int LastNumber { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
