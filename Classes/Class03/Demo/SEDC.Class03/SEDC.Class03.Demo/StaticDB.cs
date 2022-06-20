using SEDC.Class03.Demo.Models.Domain;

namespace SEDC.Class03.Demo
{
    public class StaticDB
    {
        public static List<User> Users = new()
        {
            new User()
            {
                Id = 1,
                FirstName = "Aneta",
                LastName = "Stankovska",
                Address = "Test address",
                City = "Skopje",
                Phone = "070123123"
            },

            new User()
            {
                Id = 2,
                FirstName = "Martin",
                LastName = "Panovski",
                Address = "Test address",
                City = "Skopje",
                Phone = "070123123"
            },

            new User()
            {
                Id = 3,
                FirstName = "Jovana",
                LastName = "Miskimovska",
                Address = "Test address",
                City = "Skopje",
                Phone = "070123123"
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                DateCreated = DateTime.Now,
                User = Users.SingleOrDefault(x => x.Id ==1),
                IsDelivered = false,
                Price = 100
            }
        };
    }
}
