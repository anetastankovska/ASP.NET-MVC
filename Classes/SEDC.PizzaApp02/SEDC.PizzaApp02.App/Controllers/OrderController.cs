using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp02.App.Helpers;
using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDB.Orders;
            List<OrderListViewModel> orderListViewModel = ordersFromDb.Select(x => x.MapToOrderListViewModel()).ToList();

            ViewData["Message"] = $"We have total orders of {orderListViewModel.Count}";
            ViewData["Title"] = "Orders list";
            ViewData["FirstUser"] = $"Our very first user in the system is {StaticDB.Users.FirstOrDefault()?.FirstName}";

            return View(orderListViewModel);
        }
    }
    
}
