using System.ComponentModel.DataAnnotations;

namespace CabbieFoodz.Models
{
    public class Foodz
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

    }
}

