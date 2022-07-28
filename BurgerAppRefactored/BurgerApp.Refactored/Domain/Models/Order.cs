using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Order : BaseEntity
    {
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public User User { get; set; }
        public int UserId { get; set; } 
        public PaymentMethod PaymentMethod { get; set; }
        public List<BurgerOrder> BurgerOrders { get; set; }
    }
}
