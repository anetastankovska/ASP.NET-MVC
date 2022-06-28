using BurgerApp.Models.Domain;

namespace BurgerApp.Models.ViewModels.OrderViewModels
{
    public class OrderListViewModel
    {
        public string UserFullName { get; set; }
        public Dictionary<Burger, int> Burgers { get; set; } = new Dictionary<Burger, int>();
    }
}
