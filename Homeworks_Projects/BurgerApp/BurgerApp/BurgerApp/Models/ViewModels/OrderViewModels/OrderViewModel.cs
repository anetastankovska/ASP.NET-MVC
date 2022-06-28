using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BurgerApp.Models.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter a valid full name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Please enter a valid full name")]
        public string FullName { get; set; }
        //public Dictionary<Burger, int> BurgersQty { get; set; } = new Dictionary<Burger, int>();
        public int Hamburger { get; set; }
        public int Cheeseburger { get; set; }
        public int Chickenburger { get; set; }
        public int Veggieburger { get; set; }
        public int Veganburger { get; set; }
        public int Crispyburger { get; set; }

        [Required(ErrorMessage = "Please enter a valid address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Please enter a valid address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter a valid location")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Please enter a valid cocation")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please select payment method")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Please select a payment method")]
        public PaymentMethod PaymentMethod { get; set; }

    }
}
