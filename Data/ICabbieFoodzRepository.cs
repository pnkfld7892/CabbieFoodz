using System.Collections.Generic;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public interface ICabbieFoodzRepository
    {
        public List<FoodzModel> GetAllFoodz();
        public FoodzModel GetFoodById(string id);
        public void UpdateFood(FoodzModel model);
    }
}
