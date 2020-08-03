using System.Collections.Generic;

namespace CabbieFoodz.Models
{
    public class Cabbie
    {
        public int id {get;set;}
        public string Name{get;set;}
        public string Description {get;set;}

        public IEnumerable<FoodInCabbie> FoodzInCabbie {get;set;}

    }
}
