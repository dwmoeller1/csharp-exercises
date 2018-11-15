using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class4Studio.Models;

namespace Class4Studio.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> movies = new List<string> { "movie1", "movie2", "movie3", "movie4", "movie5" };

        public IActionResult Index()
        {
            ViewBag.Movies = movies;
            return View();
        }

        public IActionResult CheckboxDelete(string[] moviesToDelete)
        {
            foreach(string movie in moviesToDelete)
            {
                movies.Remove(movie);
            }

            return Redirect("Index");
        }

        public IActionResult DropdownDelete(string movieToDelete)
        {
            movies.Remove(movieToDelete);
            return Redirect("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
