using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Helpers
{
    public static class OrderMapper
    {
        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}"
            };
        }

        public static Order MapToOrder(this OrderViewModel orderViewModel)
        {
            return new Order
            {
                Id = orderViewModel.Id,
                PaymentMethod = orderViewModel.PaymentMethod,
                User = StaticDB.Users.SingleOrDefault(x => x.Id == orderViewModel.UserId),
                Pizza = StaticDB.Pizzas.FirstOrDefault(x => x.Name == orderViewModel.PizzaName)
            };
        }
    }
}
