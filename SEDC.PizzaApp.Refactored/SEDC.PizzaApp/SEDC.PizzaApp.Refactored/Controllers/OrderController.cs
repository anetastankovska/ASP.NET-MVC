using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers.Extensions;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.OrderViewModels;

namespace SEDC.PizzaApp.Refactored.Controllers
{//Connect MVC Application with Database using EntityFramework
 //1. Implement DbContext class with all db sets and configurations
 //2. Add the DbContezt in Program.cs class
 //3. Inject the DbContext in the repositories and use it

    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        public OrderController(IOrderService order, IUserService userService)
        {
            _orderService = order;
            _userService = userService;
        }
        public IActionResult Index()
        {
            List<OrderListViewModel> orderListViewModel = _orderService.GetAllOrders();
            return View(orderListViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            ViewBag.Users = _userService.GetUsersForDropdown();
            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            try
            {
                _orderService.CreateOrder(orderViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                // We can add loggs here
                return View("ExceptionPage");
            }
        }
    }
}
