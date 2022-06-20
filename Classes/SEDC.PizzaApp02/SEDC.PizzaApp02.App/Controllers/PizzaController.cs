using Microsoft.AspNetCore.Mvc;

namespace SEDC.PizzaApp02.App.Controllers
{
    [Route("app")]
    public class PizzaController : Controller
    {
        [HttpGet("all")]
        public IActionResult Index()
        {
            var pizzas = StaticDB.Pizzas;
            if(pizzas == null) return NotFound();
            return View(pizzas);
        }

        [HttpGet("pizza-details/{id:int}")]
        public IActionResult Details(int? id)
        {
            var pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);
            if(pizza == null) return NotFound();
            return View(pizza);
        }
    }
}
