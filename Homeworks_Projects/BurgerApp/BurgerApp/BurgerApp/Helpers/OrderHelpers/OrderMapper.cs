using BurgerApp.Models.Domain;
using BurgerApp.Models.ViewModels.OrderViewModels;

namespace BurgerApp.Helpers.OrderHelpers
{
    public static class OrderMapper
    {
        public static Order MapToOrder(this OrderViewModel orderViewModel)
        {
            Dictionary<Burger, int> burgers = new Dictionary<Burger, int>();
            if (orderViewModel.Hamburger > 0)
            {
                burgers.Add(StaticDB.Burgers[0], orderViewModel.Hamburger);
            }
            if (orderViewModel.Cheeseburger > 0)
            {
                burgers.Add(StaticDB.Burgers[1], orderViewModel.Cheeseburger);
            }
            if (orderViewModel.Chickenburger > 0)
            {
                burgers.Add(StaticDB.Burgers[2], orderViewModel.Chickenburger);
            }
            if (orderViewModel.Veggieburger > 0)
            {
                burgers.Add(StaticDB.Burgers[3], orderViewModel.Veggieburger);
            }
            if (orderViewModel.Veganburger > 0)
            {
                burgers.Add(StaticDB.Burgers[4], orderViewModel.Veganburger);
            }
            if (orderViewModel.Crispyburger > 0)
            {
                burgers.Add(StaticDB.Burgers[5], orderViewModel.Crispyburger);
            }
            return new Order()
            {
                Id = orderViewModel.Id,
                FullName = orderViewModel.FullName,
                //Burgers = orderViewModel.BurgersQty,
                Burgers = burgers,
                Address = orderViewModel.Address,
                Location = orderViewModel.Location,
                PaymentMethod = orderViewModel.PaymentMethod,
            };
        }

        public static OrderViewModel MapToOrderViewModel(this Order order)
        {
            var payment = order.PaymentMethod;
            var kiro = new OrderViewModel()
            {
                Id = order.Id,
                FullName = order.FullName,
                Hamburger = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Hamburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Hamburger")] : 0,
                Cheeseburger = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Cheeseburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Cheeseburger")] : 0,
                Chickenburger = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Chickenburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Chickenburger")] : 0,
                Veggieburger = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Veggieburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Veggieburger")] : 0,
                Veganburger = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Vegan Burger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Vegan Burger")] : 0,
                Crispyburger = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Crispy Burger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Crispy Burger")] : 0,
                Address = order.Address,
                Location = order.Location,
                PaymentMethod = order.PaymentMethod
            };
            return kiro;
        }

        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel()
            {
                UserFullName = order.FullName,
                Burgers = order.Burgers
            };
        }
    }
}
