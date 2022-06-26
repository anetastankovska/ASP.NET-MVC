using BurgerApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            ViewData["GreetUser"] = "Welcome to Bob's ultimate burger delivery service";
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = StaticDB.Orders.Count() + 1;
                StaticDB.Orders.Add(order);
                return RedirectToAction("Orders");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(Order order)
        {
            return View();
        }
    }
}
