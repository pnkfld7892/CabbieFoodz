using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CabbieFoodz.Data;
using CabbieFoodz.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CabbieFoodz
{
    public class FoodzController : Controller
    {
        private readonly ICabbieFoodzRepository _repo;
        private readonly IMapper _mapper;

        public FoodzController(ICabbieFoodzRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
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
        public IActionResult FoodzView(int id)
        {
            var food = _repo.GetFoodById(id);
            if(food == null)
            {
                return NotFound();
            }
            return View(_mapper.Map<FoodzViewModel>(food));
        }

        [HttpPost]
        [Route("foodz/{id}")]
        public IActionResult FoodzView(FoodzViewModel model)
        {
           var food = _repo.GetFoodById(model.id);
           if(food==null)
           {
               return NotFound();
           }
           _mapper.Map(model,food);
           _repo.UpdateFood(food);
            return RedirectToAction("Index");
        }
    }
}
