
using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents;

//[ViewComponent] - ako ne stavimo ViewComponent u nazivu class
public class GridViewComponent : ViewComponent
{
    // svaki ViewComponent ima metod InvokeAsync
    // kad god zovemo ovu metodu  -> trazi partial view na odredjenoj lokaciji ...
    public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
    {
        //PersonGridModel personGridModel = new PersonGridModel()
        //{
        //    GridTitle = "Persons List",
        //    Persons = new List<Person>()
        //    {
        //        new Person() {PersonName = "Igor", JobTitle = "Developer"},
        //        new Person() {PersonName = "Jovana", JobTitle = "Content Writer"},
        //        new Person() {PersonName = "Nina", JobTitle = "Trainer"},
        //        new Person() {PersonName = "Andrea", JobTitle = "Artist"},
        //    }
        //};

        //ViewData["Grid"] = personGridModel; /*-  ne treba kad ubacimo model u View kao parametar*/

        //return View(viewName:"Sample"); - ako ne stavimo Default.cshtml
        //return View(personGridModel); - ne stavljamo model kad ubacujemo parametar metode InvokeAsync
        return View("Sample", grid); // invoked a partial view => Views/Shared/Components/Grid/Default.cshtml
    }
}
