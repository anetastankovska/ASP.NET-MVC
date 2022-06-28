using BurgerApp.Models.Enums;

namespace BurgerApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; } = false;
        public Dictionary<Burger, int> Burgers { get; set; } = new Dictionary<Burger, int>();
        public string Location { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public Order() { }
        public Order(int id, string fullName, string address, bool isDelivered, Dictionary<Burger, int> burgers, string location, PaymentMethod paymentMethod)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            IsDelivered = isDelivered;
            Burgers = burgers;
            Location = location;
            PaymentMethod = paymentMethod;
        }
    }
}
