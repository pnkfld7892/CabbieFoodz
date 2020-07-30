using System;
using System.Collections.Generic;
using System.Linq;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public class MockFoodzRepo : ICabbieFoodzRepository
    {
        private List<Foodz> _foodz = new List<Foodz>()
        {
            new Foodz{id = new Guid().ToString(),Name="Tortillas",Description="10 Pack of soft taco tortillas"},
            new Foodz{id = new Guid().ToString (),Name="Ortega Beans",Description="12 oz can of refried beans"},
            new Foodz{id = new Guid().ToString (),Name="Petitie Diced Tomatoes",Description="18 oz can of petite diced tomatoes"}
        };
        public List<Foodz> GetAllFoodz()
        {
            return _foodz;
        }

        public Foodz GetFoodById(string id)
        {
            return _foodz.FirstOrDefault(f => f.id == id);
        }
    }
}