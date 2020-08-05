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
        public IActionResult Index()
        {
            var cabbies = _repo.GetCabbies();

            return View(_mapper.Map<List<CabbieViewModel>>(cabbies));
        }
    }
}
