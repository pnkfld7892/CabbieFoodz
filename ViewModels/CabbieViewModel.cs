using System.Collections.Generic;

namespace CabbieFoodz.ViewModels
{
    public class CabbieViewModel
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public string Description { get; set; }
        public List<FoodInCabbieViewModel> FoodzInCabbie {get;set;}
        
    }
}
