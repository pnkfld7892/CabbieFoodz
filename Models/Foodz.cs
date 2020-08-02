using System.ComponentModel.DataAnnotations;

namespace CabbieFoodz.Models
{
    public class FoodzModel
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

    }
}

