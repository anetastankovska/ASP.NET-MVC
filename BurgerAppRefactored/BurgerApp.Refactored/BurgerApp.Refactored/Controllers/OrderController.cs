using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Refactored.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
