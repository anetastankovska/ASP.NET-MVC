using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Order details:";
            if(id == null)
            {
                return new EmptyResult();
            }
            var orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            if (orderFromDb == null)
            {
                return NotFound();
            }

            OrderDetailsViewModel orderDetailsViewModel = orderFromDb.MapToOrderDetailsViewModel();
            return View(orderDetailsViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Users = StaticDB.Users.Select(x => x.MapToUserSelectViewModel()).ToList();

            //Another way
            //var users = new SelectList(StaticDB.Users).Select(x => x.MapToUserSelectViewModel()).ToList();

            OrderViewModel order = new OrderViewModel();
            return View(order);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                orderViewModel.Id = StaticDB.Orders.Count() + 1;
                Pizza pizzaFromDb = StaticDB.Pizzas.FirstOrDefault(x => x.Name.ToLower() == orderViewModel.PizzaName.ToLower());
                if (pizzaFromDb == null)
                {
                    return View("ResourceNotFound");
                }
                StaticDB.Orders.Add(orderViewModel.MapToOrder());
                return RedirectToAction("Index");
            }

            return View(orderViewModel);
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }

            Order orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            if(orderFromDb == null)
            {
                return View("ResourceNotFound");
            }

            OrderDetailsViewModel orderDetailsViewModel = orderFromDb.MapToOrderDetailsViewModel();

            return View(orderDetailsViewModel);
        }

        public IActionResult ConfirmDelete(int? id)
        {
            Order orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            if(orderFromDb == null)
            {
                return View("ResourceNotFound");
            }
            StaticDB.Orders.Remove(orderFromDb);
            return RedirectToAction("Index");
        }
    }


    //Create edit action for home,
    //add edit view model,
    //add view for editing orders,
    //don't forget to populate the users list so that it wil be displayed for editing


}
