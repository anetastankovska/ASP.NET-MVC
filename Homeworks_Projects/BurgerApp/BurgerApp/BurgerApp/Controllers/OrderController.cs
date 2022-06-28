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
            OrderViewModel orderViewModel = new OrderViewModel();
            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            
            if (ModelState.IsValid)
            {
                orderViewModel.Id = StaticDB.Orders.Count() + 1;
                StaticDB.Orders.Add(orderViewModel.MapToOrder());
                return RedirectToAction("Index");
            }
            return View(orderViewModel);
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
            if (id == null)
            {
                return new EmptyResult();
            }
            var orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            if (orderFromDb == null)
            {
                return NotFound();
            }

            DetailsViewModel detailsViewModel = orderFromDb.MapToOrderDetailsViewModel();
            return View(detailsViewModel);
        }
    }
}
