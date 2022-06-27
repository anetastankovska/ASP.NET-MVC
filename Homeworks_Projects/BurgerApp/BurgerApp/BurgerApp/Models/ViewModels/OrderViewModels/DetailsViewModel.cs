using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;

namespace BurgerApp.Models.ViewModels.OrderViewModels
{
    public class DetailsViewModel
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public List<Burger> Burgers { get; set; }
        public double TotalPrice { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool Delivered { get; set; }
        
        

    }
}
