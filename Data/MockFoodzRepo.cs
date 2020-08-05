using System;
using System.Collections.Generic;
using System.Linq;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public class MockFoodzRepo : ICabbieFoodzRepository
    {
        private List<Food> _foodz = new List<Food>()
        {
            new Food{Id = 1,Name="Tortillas",Description="10 Pack of soft taco tortillas"},
            new Food{Id = 2,Name="Ortega Beans",Description="12 oz can of refried beans"},
            new Food{Id = 3,Name="Petitie Diced Tomatoes",Description="18 oz can of petite diced tomatoes"}
        };

        public void CreateFoodz(Food foodModel)
        {
            foodModel.Id = _foodz.Count + 1;
            _foodz.Add(foodModel);
        }

        public List<Food> GetFoodz()
        {
            return _foodz;
        }

        public Food GetFoodById(int id)
        {
            return _foodz.FirstOrDefault(f => f.Id == id);
        }

        public void UpdateFood(Food model)
        {
            var food = _foodz.FirstOrDefault(f=> f.Id ==model.Id);

            if(food ==null)
                throw new ArgumentNullException("Food couldn't be found");
            food.Name = model.Name;
            food.Description = model.Description;
        }

        
        public List<Cabbie> GetCabbies()
        {
            throw new NotImplementedException();
        }

        public Cabbie GetCabbieById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
