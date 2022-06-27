namespace BurgerApp.Models.Domain
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public Burger(int id, string name, double price, bool isVegetarian, bool isVegan, bool hasFries)
        {
            Id = id;
            Name = name;
            Price = price;
            IsVegeterian = isVegetarian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }

        public Burger() { }
    }
}


