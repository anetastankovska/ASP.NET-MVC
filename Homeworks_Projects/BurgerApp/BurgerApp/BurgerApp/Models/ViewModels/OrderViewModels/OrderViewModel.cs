using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;

namespace BurgerApp.Models.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        //public Dictionary<Burger, int> BurgersQty { get; set; } = new Dictionary<Burger, int>();
        public int Hamburger { get; set; }
        public int Cheeseburger { get; set; }
        public int Chickenburger { get; set; }
        public int Veggieburger { get; set; }
        public int Veganburger { get; set; }
        public int Crispyburger { get; set; }

        public string Address { get; set; }
        public string Location { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
