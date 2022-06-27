using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;

namespace BurgerApp.Models.ViewModels.OrderViewModels
{
    public class CreateViewModel
    {
        public string FullName { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public bool IsDelivered { get; set; } = false;
        public PaymentMethod PaymentMethod { get; set; }

    }
}
