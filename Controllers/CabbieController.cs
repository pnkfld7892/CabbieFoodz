using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CabbieFoodz.Data;
using Microsoft.AspNetCore.Mvc;

namespace CabbieFoodz.Controllers
{
    public class CabbieController : Controller
    {
        private readonly ICabbieFoodzRepository _repo;

        public CabbieController(ICabbieFoodzRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
