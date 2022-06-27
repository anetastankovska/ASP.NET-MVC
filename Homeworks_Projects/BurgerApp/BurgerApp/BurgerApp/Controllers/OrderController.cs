using BurgerApp.Helpers.OrderHelpers;
using BurgerApp.Models.Domain;
using BurgerApp.Models.ViewModels.OrderViewModels;
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
            List<Order> ordersFromDB = StaticDB.Orders;
            List<DetailsViewModel> allOrdersViewModel = ordersFromDB.Select(x => x.MapToOrderDetailsViewModel()).ToList();

            ViewData["TotalOrders"] = $"We have total orders of {allOrdersViewModel.Count}";
            ViewData["Title"] = "Orders list";

            return View(allOrdersViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Order order = new Order();
            return View(order);
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

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var order = StaticDB.Orders.SingleOrDefault(x => x.Id == id);

            }
            return View();

        }

        public IActionResult Details(int? id)
        {
            //DetailsViewModel detailsViewModel = order.MapToOrderDetailsViewModel();

            ViewData["Title"] = "Orders details";

            return View(detailsViewModel);
        }
    }
}
