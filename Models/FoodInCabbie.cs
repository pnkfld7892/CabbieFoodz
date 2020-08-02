namespace CabbieFoodz.Models
{
    public class FoodInCabbie
    {
        public int id {get;set;}

        public int Qty {get;set;}
        public int FoodzId{get;set;}
        public FoodzModel Food{get;set;}
        public int CabbieId{get;set;}
        public CabbieModel Cabbie {get;set;}
    }
}
