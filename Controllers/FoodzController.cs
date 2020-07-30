using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CabbieFoodz.Data;
using CabbieFoodz.Models;
using CabbieFoodz.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CabbieFoodz
{
    public class FoodzController : Controller
    {
        private readonly ICabbieFoodzRepository _repo;

        public FoodzController(ICabbieFoodzRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new FoodzIndexViewModel(){
                Foodiez = _repo.GetAllFoodz()
            };
            return View(model);
        }

        [HttpGet]
        [Route("foodz/{id}")]
        public IActionResult FoodzView(string id)
        {
            return View();
        }
    }
}
