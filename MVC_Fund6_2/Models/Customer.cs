using System;
using System.Collections.Generic;


namespace MVC_Fund6_2.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}