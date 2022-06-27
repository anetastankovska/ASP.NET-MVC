﻿using SEDC.PizzaApp02.App.Models.Enums;

namespace SEDC.PizzaApp02.App.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Price { get; set; }
        public bool IsDelivered { get; set; }
    }
}
