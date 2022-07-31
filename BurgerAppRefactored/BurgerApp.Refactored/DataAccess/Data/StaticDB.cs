using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class StaticDB
    {
        public static int BurgerId { get; set; }
        public static int OrderId { get; set; }
        public static int UserId { get; set; }
        public static int BurgerOrderId { get; set; }
        public static List<Burger> Burgers { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }

        static StaticDB()
        {
            BurgerId = 3;
            OrderId = 2;
            UserId = 2;
            BurgerOrderId = 3;

            Burgers = new List<Burger> 
            { 
                new Burger
                {
                    Id = 1,
                    Name = "Hamburger",
                    IsOnPromotion = false,
                    Price = 150,
                    BurgerOrders = new List<BurgerOrder>{}
                },
                new Burger 
                {
                    Id = 2,
                    Name = "Cheeseburger",
                    IsOnPromotion = true,
                    Price = 170,
                    BurgerOrders = new List<BurgerOrder>{}
                },
                new Burger
                {
                    Id = 3,
                    Name = "Chickenburger",
                    IsOnPromotion = true,
                    Price = 160,
                    BurgerOrders = new List<BurgerOrder>{}
                }
            };

            Users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Aneta",
                    LastName = "Stankovska",
                    Address = "Sava Kovacevikj 7",
                    Orders = new List<Order>{}
                },
                new User
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Partizanski Odredi 1",
                    Orders = new List<Order>{}
                }
            };

            Orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    PaymentMethod = PaymentMethod.Card,
                    IsDelivered = true,
                    Address = "Store1",
                    BurgerOrders = new List<BurgerOrder>
                    {
                        new BurgerOrder
                        {   Id = 1,
                            Burger = Burgers[0],
                            BurgerId = Burgers[0].Id,
                            OrderId = 1
                        },
                        new BurgerOrder
                        {
                            Id = 2,
                            Burger = Burgers[1],
                            BurgerId = Burgers[1].Id,
                            OrderId = 1
                        }
                    },
                    User = Users[0]
                },
                new Order
                {
                    Id = 2,
                    PaymentMethod = PaymentMethod.Cash,
                    IsDelivered = false,
                    Address = "Store2",
                    BurgerOrders = new List<BurgerOrder>
                    {
                        new BurgerOrder
                        {
                            Id = 3,
                            Burger = Burgers[1],
                            BurgerId = Burgers[1].Id,
                            OrderId  = 2
                        }
                    },
                    User = Users [1]
                }
            };
        }
    }
}
