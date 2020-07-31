using System;
using System.Collections.Generic;
using System.Linq;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public class MockFoodzRepo : ICabbieFoodzRepository
    {
        private List<FoodzModel> _foodz = new List<FoodzModel>()
        {
            new FoodzModel{id = Guid.NewGuid().ToString(),Name="Tortillas",Description="10 Pack of soft taco tortillas"},
            new FoodzModel{id = Guid.NewGuid().ToString(),Name="Ortega Beans",Description="12 oz can of refried beans"},
            new FoodzModel{id = Guid.NewGuid().ToString(),Name="Petitie Diced Tomatoes",Description="18 oz can of petite diced tomatoes"}
        };

        public void EditFood(FoodzModel food)
        {
            
        }


        public List<FoodzModel> GetAllFoodz()
        {
            return _foodz;
        }

        public FoodzModel GetFoodById(string id)
        {
            return _foodz.FirstOrDefault(f => f.id == id);
        }

        
    }
}
