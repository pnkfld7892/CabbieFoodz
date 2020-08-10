using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CabbieFoodz.Data;
using CabbieFoodz.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CabbieFoodz.Controllers
{
    public class CabbieController : Controller
    {
        private readonly ICabbieFoodzRepository _repo;
        private readonly IMapper _mapper;

        public CabbieController(ICabbieFoodzRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var cabbies = _repo.GetCabbies();

            return View(_mapper.Map<List<CabbieViewModel>>(cabbies));
        }

        [HttpGet]
        [Route("/cabbie/{id}")]
        public IActionResult CabbieView(int id)
        {
            var cabbie = _repo.GetCabbieById(id);
            if (cabbie == null)
            {
                return NotFound();
            }
            return View(_mapper.Map<CabbieViewModel>(cabbie));
        }

    }
}
