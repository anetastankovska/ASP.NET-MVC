using SEDC.PizzaApp02.App.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp02.App.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza name")]
        [Required(ErrorMessage = "Please enter a pizza name. Ex: Capri")]
        public string PizzaName { get; set; }
        [Required(ErrorMessage = "Please select payment method")]
        public PaymentMethod PaymentMethod { get; set; }
        public int UserId { get; set; }
    }
}
