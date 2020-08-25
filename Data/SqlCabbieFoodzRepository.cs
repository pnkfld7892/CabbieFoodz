using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CabbieFoodz.Models;

namespace CabbieFoodz.Data
{
    public class SqlCabbieFoodzRepository : ICabbieFoodzRepository
    {
        private readonly CabbieFoodzContext _context;

        public SqlCabbieFoodzRepository(CabbieFoodzContext context)
        {
            _context = context;
        }
        public void CreateFoodz(Food foodModel)
        {
            if (foodModel == null)
            {
                throw new ArgumentNullException(nameof(foodModel));
            }

            _context.Foodz.Add(foodModel);
        }

        public Cabbie GetCabbieById(int id)
        { 
            var cabbie = _context.Cabbies
                .Include(c => c.FoodzInCabbie)
                .ThenInclude(f => f.Food)
                .FirstOrDefault(c => c.Id == id);
            return _context.Cabbies.FirstOrDefault(c => c.Id == id);
        }

        public List<Cabbie> GetCabbies()
        {
            return _context.Cabbies.ToList();
        }

        public Food GetFoodById(int id)
        {
            return _context.Foodz.FirstOrDefault(f => f.Id == id);
        }

        public List<Food> GetFoodz()
        {
            return _context.Foodz.ToList();
        }

        public void UpdateFood(Food model)
        {
            
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public List<FoodInCabbie> GetFoodInCabbies()
        {
            return _context.FoodInCabbies.ToList();
        }

        public List<FoodInCabbie> GetFoodInCabbieByCabbieId(int cabbieId)
        {
            var retVal = _context.FoodInCabbies
                .Where(f => f.Cabbie.Id == cabbieId).ToList();
            return retVal;
        }
    }
}
