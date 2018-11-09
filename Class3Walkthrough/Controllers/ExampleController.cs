using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Class3Walkthrough.Controllers
{
    public class ExampleController : Controller
    {
        [HttpGet]
        public IActionResult ExamplePage()
        {
            return Content(htmlString, "text/html");
        }

        [HttpPost]
        public IActionResult ExamplePage(string firstName, string lastName)
        {
            return Content(input);
        }

        string htmlString = @"<body>
                                 <ul>
                                        <form action='/example/examplepage' method='post'>
                                        <input type='text' name='firstName'/>
                                        <input type='text' name='lastName'/>
                                        <button type='submit'/>
                                        </form>
                                       <li>This</li>
                                        <li>is</li>
                                        <li>an</li>
                                        <li>example</li>
                                 </ul>
                              </body>";
    }
}
}