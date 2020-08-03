namespace CabbieFoodz.Models
{
    public class FoodInCabbie
    {
        public int id {get;set;}

        public int Qty {get;set;}
        public int FoodzId{get;set;}
        public Foodz Food{get;set;}
        public int CabbieId{get;set;}
        public Cabbie Cabbie {get;set;}
    }
}
