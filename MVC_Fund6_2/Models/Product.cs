using System;


namespace MVC_Fund6_2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}