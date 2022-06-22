using Microsoft.AspNetCore.Mvc;
using SEDC.Class04.Demo.Models;

namespace SEDC.Class04.Demo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new User()
            {
                Id = 1,
                FirstName = "Aneta",
                LastName = "Stankovska",
                Age = 30,
                City = "Skopje",
                IsEmployed = true
            };
            return View(user);
        }
    }
}
