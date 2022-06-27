using BurgerApp.Models.ViewModels.OrderViewModels;
using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;

namespace BurgerApp.Helpers.OrderHelpers
{
    public static class OrderDetailsMapper
    {
        public static double CalculateTotalBurgersPrice(this Order order)
        {
            try
            {
                double totalPrice = 0;
                totalPrice = order.Burgers.Sum(x => x.Price);
                return totalPrice;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DetailsViewModel MapToOrderDetailsViewModel(this Order order)
        {
            return new DetailsViewModel
            {
                OrderId = order.Id,
                UserName = order.FullName,
                Burgers = order.Burgers,
                TotalPrice = order.CalculateTotalBurgersPrice(),
                Address = order.Address,
                Location = order.Location,
                PaymentMethod = order.PaymentMethod,
                Delivered = order.IsDelivered
            };
        }
    }
}
