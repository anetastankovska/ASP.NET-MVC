using SEDC.Class05.Demo.App.Models;

namespace SEDC.Class05.Demo.App
{
    public static class StaticDb
    {
        public static List<User> Users = new()
        {
            new User
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bobsky",
                Address = "Bob Street 22",
                Age = 25,
                City = "Skopje",
                //IsEmployed = true
            },

            new User
            {
                Id = 1,
                FirstName = "Jill",
                LastName = "Wayne",
                Address = "Jill Street 23",
                Age = 30,
                City = "Skopje",
                //IsEmployed = true
            }
        };
    }
}
