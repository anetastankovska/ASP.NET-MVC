using BurgerApp.Models.Domain;

namespace BurgerApp
{
    public class StaticDB
    {
        public static List<Burger> Burgers = new()
        {
            new Burger
            {
                Name = "Hamburger",
                Price = 140,
                IsVegeterian = false,
                IsVegan = false,
                HasFries = true
            },

            new Burger
            {
                Name = "Cheeseburger",
                Price = 160,
                IsVegeterian = false,
                IsVegan = false,
                HasFries = true
            },

            new Burger
            {
                Name = "Chickenburger",
                Price = 150,
                IsVegeterian = false,
                IsVegan = false,
                HasFries = true
            },

            new Burger
            {
                Name = "Veggieburger",
                Price = 190,
                IsVegeterian = true,
                IsVegan = false,
                HasFries = true
            },

            new Burger
            {
                Name = "Vegan Burger",
                Price = 200,
                IsVegeterian = true,
                IsVegan = true,
                HasFries = false
            },

            new Burger
            {
                Name = "Crispy Burger",
                Price = 180,
                IsVegeterian = false,
                IsVegan = false,
                HasFries = true
            }

        };

        //public static List<Burger> Burgers { get; set; } = new List<Burger>();
        public static List<Order> Orders { get; set; } = new List<Order>();



        static StaticDB()
        {
            //Burger Hamburger = new Burger("Hamburger", 140, false, false, true);
            //Burger Cheesburger = new Burger("Cheeseburger", 160, false, false, true);
            //Burger Chickenburger = new Burger("Chickenburger", 150, false, false, true);
            //Burger Crispyburger = new Burger("Crispy burger", 190, true, true, false);
            //Burger VeggieBurger = new Burger("Veggieburger", 190, true, false, true);
            //Burger Veganburger = new Burger("Vegan burger", 200, true, true, false);

            //Burgers.Add(Hamburger);
            //Burgers.Add(Cheesburger);
            //Burgers.Add(Chickenburger);
            //Burgers.Add(Crispyburger);
            //Burgers.Add(VeggieBurger);
            //Burgers.Add(Veganburger);

            Orders.Add(new Order(1, "Aneta Stankovska", "str. 527 no. 1-32", false, new List<Burger>() { Burgers[4], Burgers[5] }, "Kisela Voda"));
            Orders.Add(new Order(2, "Aleksandar Zivkovic", "str. Sava Kovacevikj no. 10", false, new List<Burger>() { Burgers[0], Burgers[1] }, "Kisela Voda"));
            Orders.Add(new Order(3, "Stefan Ivanovski", "str. Boris Trakovski no. 150", false, new List<Burger>() { Burgers[3], Burgers[1], Burgers[2] }, "Kisela Voda"));

        }


    }
}
