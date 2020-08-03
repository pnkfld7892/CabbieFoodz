using System.Collections.Generic;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public interface ICabbieFoodzRepository
    {
        public List<Foodz> GetAllFoodz();
        public Foodz GetFoodById(int id);
        public void UpdateFood(Foodz model);
        void CreateFoodz(Foodz foodModel);
    }
}
