using System.Collections.Generic;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public interface ICabbieFoodzRepository
    {
        public List<Foodz> GetAllFoodz();
        public Foodz GetFoodById(string id);
    }
}