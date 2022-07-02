using BurgerApp.Models.Domain;
using BurgerApp.Models.ViewModels.OrderViewModels;

namespace BurgerApp.Helpers.OrderHelpers
{
    public static class OrderMapper
    {
        public static Order MapToOrder(this OrderViewModel orderViewModel)
        {
            Dictionary<Burger, int> burgers = new Dictionary<Burger, int>();
            if (orderViewModel.HamburgerCount > 0)
            {
                burgers.Add(StaticDB.Burgers[0], orderViewModel.HamburgerCount);
            }
            if (orderViewModel.CheeseburgerCount > 0)
            {
                burgers.Add(StaticDB.Burgers[1], orderViewModel.CheeseburgerCount);
            }
            if (orderViewModel.ChickenburgerCount > 0)
            {
                burgers.Add(StaticDB.Burgers[2], orderViewModel.ChickenburgerCount);
            }
            if (orderViewModel.VeggieburgerCount > 0)
            {
                burgers.Add(StaticDB.Burgers[3], orderViewModel.VeggieburgerCount);
            }
            if (orderViewModel.VeganburgerCount > 0)
            {
                burgers.Add(StaticDB.Burgers[4], orderViewModel.VeganburgerCount);
            }
            if (orderViewModel.CrispyburgerCount > 0)
            {
                burgers.Add(StaticDB.Burgers[5], orderViewModel.CrispyburgerCount);
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
                HamburgerCount = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Hamburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Hamburger")] : 0,
                CheeseburgerCount = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Cheeseburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Cheeseburger")] : 0,
                ChickenburgerCount = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Chickenburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Chickenburger")] : 0,
                VeggieburgerCount = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Veggieburger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Veggieburger")] : 0,
                VeganburgerCount = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Vegan Burger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Vegan Burger")] : 0,
                CrispyburgerCount = order.Burgers.ContainsKey(StaticDB.Burgers.FirstOrDefault(x => x.Name == "Crispy Burger")) ? order.Burgers[StaticDB.Burgers.FirstOrDefault(x => x.Name == "Crispy Burger")] : 0,
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
