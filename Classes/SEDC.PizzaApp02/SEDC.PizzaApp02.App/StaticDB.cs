using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.Enums;

namespace SEDC.PizzaApp02.App
{
    public static class StaticDB
    {
        public static List<Pizza> Pizzas = new()
        {
            new Pizza
            {
                Id = 1,
                Name = "Capri",
                Price = 220,
                IsOnPromotion = false
            },

            new Pizza
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 320,
                IsOnPromotion = false
            },

            new Pizza
            {
                Id = 3,
                Name = "Vege",
                Price = 320,
                IsOnPromotion = true
            }
        };

        public static List<User> Users = new()
        {
            new User
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bobsky",
                Address = "Bob Street 22",
            },

            new User
            {
                Id = 2,
                FirstName = "Jill",
                LastName = "Wayne",
                Address = "Jill Street 23",
            }
        };

        public static List<Order> Orders = new()
        {
            new Order
            {
                Id = 1,
                User = Users.First(),
                Pizza = Pizzas.Last(),
                PaymentMethod = PaymentMethod.Card,
                IsDelivered = true
            },

            new Order
            {
                Id = 2,
                User = Users.Last(),
                Pizza = Pizzas.First(),
                PaymentMethod = PaymentMethod.Cash,
                IsDelivered = false
            },
        };
    }
}
