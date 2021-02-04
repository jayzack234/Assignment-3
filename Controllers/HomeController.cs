//Home Controller
using Assignment_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        //Below is where we will check whether the movie is invalid.
        //If the movie is Independence Day, it won't excute the addmovie method with its associating parameter, thus never displaying it
        [HttpPost]
        public IActionResult MovieForm(MovieResponse movResponse)
        {
            if (movResponse.Title == "Independence Day")
                {
                return View();
            }
            else {
                Hold.AddMovie(movResponse);
                return View("Display", movResponse);
            }
        }

        //This will return the information compiled in our hold model
        public IActionResult List()
        {
            return View(Hold.Movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
