using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CabbieFoodz.Data;
using CabbieFoodz.Models;
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
        public IActionResult FoodzView(string id)
        {
            var food = _repo.GetFoodById(id);
            if(food == null)
                return NotFound();
//            var viewModel = new FoodzViewModel
 //           {
 //               id = food.id,
 //               Name = food.Name,
 //               Description = food.Description
 //           };
            return View(_mapper.Map<FoodzViewModel>(food));
        }

        [HttpPost]
        [Route("foodz/{id}")]
        public IActionResult FoodzView(FoodzViewModel model)
        {
            
            return View(model);
        }
    }
}
