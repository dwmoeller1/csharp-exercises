using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class3Studio.Models;
using System.IO;

namespace Class3Studio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Welcome()
        {
            string htmlString = System.IO.File.ReadAllText("welcome_html.txt");
            return Content(htmlString, "text/html");
        }

        [HttpPost]
        public IActionResult Welcome(string name, string language)
        {
            Dictionary<string, string> languageDict = GreetingDictionary();
            string greeting = languageDict[language];
            return Content($"{greeting}, {name}!");
        }

        private Dictionary<string, string> GreetingDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("English", "Hello");
            dict.Add("Russian", "Priviet");
            dict.Add("French", "Bonjour");
            dict.Add("Spanish", "Hola");
            dict.Add("Canadian", "Hi, eh?");
            return dict;
        }
    }
}
