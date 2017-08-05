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

        public IActionResult Details(int id)
        {
            //return id.ToString();
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Cuisine = model.Cuisine;
                newRestaurant.Name = model.Name;

                _restaurantData.Add(newRestaurant);

                //return View("Details", newRestaurant); //duplicate post will happen

                //return RedirectToAction("Details", newRestaurant);
                return RedirectToAction("Details", new { id = newRestaurant.Id });
            }
            else
            {
                return View();
            }
            
        }
    }
}
