using System.ComponentModel.DataAnnotations;

namespace CabbieFoodz.Models
{
    public class FoodInCabbie
    {
        public int Id { get; set; }

        [Required]
        public int Qty { get; set; }
        public int FoodzId { get; set; }
        public Food Food { get; set; }
        public int CabbieId { get; set; }
        public Cabbie Cabbie { get; set; }
    }
}
