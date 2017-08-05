using Microsoft.AspNetCore.Mvc;
using otf.Entities;
using otf.Services;
using otf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace otf.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();
          // var model= _restaurantData.GetAll();
            //var model = new Restaurant { Id = 1, Name = "The House of Kobe" };
            return View(model);
        }
    }
}
