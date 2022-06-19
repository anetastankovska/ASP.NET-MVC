namespace BurgerApp.Models.Domain
{
    public class Burger
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public Burger(string name, float price, bool isVegetarian, bool isVegan, bool hasFries)
        {
            Name = name;
            Price = price;
            IsVegeterian = isVegetarian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}


