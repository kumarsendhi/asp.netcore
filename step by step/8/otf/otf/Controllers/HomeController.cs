using Microsoft.AspNetCore.Mvc;
using otf.Models;
using otf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace otf.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
           var model= _restaurantData.GetAll();
            //var model = new Restaurant { Id = 1, Name = "The House of Kobe" };
            return View(model);
        }
    }
}
