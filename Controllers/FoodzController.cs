using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CabbieFoodz.Models;
using Microsoft.AspNetCore.Mvc;

namespace CabbieFoodz
{
    public class FoodzController : Controller
    {
        public IActionResult Index()
        {
            var model = new FoodzViewModel(){
                Foodiez = new 
                List<Foodz>(){
                new Foodz{Name="Beans", Description="12 oz can of beans!"},
                new Foodz{Name="Tortiallas",Description="10 pack of soft taco tortillas"}
            }};
            return View(model);
        }
    }
}
