using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
        
        [Route("friends-list")]
        public IActionResult LoadFriendsList()
        {
            PersonGridModel personGridModel = new()
            {
                GridTitle = "Friends",
                Persons = new List<Person>()
                {
                    new Person() { PersonName = "Mia", JobTitle = "Developer"},
                    new Person() { PersonName = "Ema", JobTitle = "QA"},
                    new Person() { PersonName = "April", JobTitle = "Designer"}
                }
            };
            // moramo ubaciti ime componenta(bez ViewComponent) i eventuialno model ukoliko imamom
            return ViewComponent("Grid", new {grid = personGridModel });
        }

    }
}
