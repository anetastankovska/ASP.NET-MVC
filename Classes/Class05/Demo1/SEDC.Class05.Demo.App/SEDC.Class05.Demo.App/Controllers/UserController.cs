using Microsoft.AspNetCore.Mvc;

namespace SEDC.Class05.Demo.App.Controllers
{
    public class UserController : Controller
    {
        Route[("user")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
