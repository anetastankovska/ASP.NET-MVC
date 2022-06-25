using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Helpers
{
    public static class OrderDetailsMapper
    {
        public static OrderDetailsViewModel MapOrderDetailsViewModel(this Order order)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = order.Pizza.Name,
                UserName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price,
                Delivered = order.IsDelivered
            };
        }
    }
}
