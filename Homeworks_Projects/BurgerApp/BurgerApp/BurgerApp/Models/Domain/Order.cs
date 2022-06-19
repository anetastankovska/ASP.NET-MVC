namespace BurgerApp.Models.Domain
{
    public class Order
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; } = new List<Burger>();
        public string Location { get; set; }

        public Order(string fullName, string address, bool isDelivered, List<Burger> burgers, string location)
        {
            FullName = fullName;
            Address = address;
            IsDelivered = isDelivered;
            Burgers = burgers;
            Location = location;
        }
    }
}
