using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CabbieFoodz.Models
{
    public class Cabbie
    {
        [Key]
        public int Id {get;set;}

        [Required]
        [MaxLength(255)]
        public string Name{get;set;}


        [Required]
        [MaxLength(255)]
        public string Description {get;set;}

        public IList<FoodInCabbie> FoodzInCabbie {get;set;}

    }
}
