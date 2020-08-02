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
            new FoodzModel{id = 1,Name="Tortillas",Description="10 Pack of soft taco tortillas"},
            new FoodzModel{id = 2,Name="Ortega Beans",Description="12 oz can of refried beans"},
            new FoodzModel{id = 3,Name="Petitie Diced Tomatoes",Description="18 oz can of petite diced tomatoes"}
        };

        public void CreateFoodz(FoodzModel foodModel)
        {
            foodModel.id = _foodz.Count + 1;
            _foodz.Add(foodModel);
        }

        public List<FoodzModel> GetAllFoodz()
        {
            return _foodz;
        }

        public FoodzModel GetFoodById(int id)
        {
            return _foodz.FirstOrDefault(f => f.id == id);
        }

        public void UpdateFood(FoodzModel model)
        {
            var food = _foodz.FirstOrDefault(f=> f.id ==model.id);

            if(food ==null)
                throw new ArgumentNullException("Food couldn't be found");
            food.Name = model.Name;
            food.Description = model.Description;
        }
    }
}
