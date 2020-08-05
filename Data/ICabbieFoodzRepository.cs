using System.Collections.Generic;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public interface ICabbieFoodzRepository
    {
        public List<Food> GetFoodz();
        public Food GetFoodById(int id);
        public void UpdateFood(Food model);
        void CreateFoodz(Food foodModel);

        public List<Cabbie> GetCabbies();
        public Cabbie GetCabbieById(int id);
        public bool SaveChanges();
    }
}
