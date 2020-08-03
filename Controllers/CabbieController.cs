using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CabbieFoodz.Controllers
{
    public class CabbieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
