using System.ComponentModel.DataAnnotations;

namespace CabbieFoodz.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

    }
}

