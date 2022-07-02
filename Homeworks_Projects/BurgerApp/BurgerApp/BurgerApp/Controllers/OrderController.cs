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
                var typed = orderViewModel.GetType().GetProperties().Where(x => x.PropertyType == typeof(int)).Skip(1).ToList();
                var sum = typed.Select(x => (int)x.GetValue(orderViewModel)).Sum();
                if (sum <= 0)
                {
                    return View(orderViewModel);
                }
                    orderViewModel.Id = StaticDB.Orders.Count() + 1;
                StaticDB.Orders.Add(orderViewModel.MapToOrder());
                return RedirectToAction("Index");
            }
            return View(orderViewModel);

            //var typed = orderViewModel.GetType().GetProperties().Where(x => x.PropertyType == typeof(int)).Skip(1).ToList();
            //var sum = typed.Select(x => (int)x.GetValue(orderViewModel)).Sum();
        //    if (sum > 0)
        //    {
        //        return View(orderViewModel);
        //    }
        //    return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                Order updatedOrder = orderViewModel.MapToOrder();
                var orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == updatedOrder.Id);
                orderFromDb.FullName = updatedOrder.FullName;
                orderFromDb.Burgers = updatedOrder.Burgers;
                orderFromDb.Address = updatedOrder.Address;
                orderFromDb.Location = updatedOrder.Location;
                orderFromDb.PaymentMethod = updatedOrder.PaymentMethod;
                return RedirectToAction("Index");
            }
            return View(orderViewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
                if(orderFromDb == null)
                {
                    return NotFound();
                }
                var orderViewModel = orderFromDb.MapToOrderViewModel();

                return View(orderViewModel);
            }
            return NotFound();
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
