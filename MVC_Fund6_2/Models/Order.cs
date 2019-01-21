using System;


namespace MVC_Fund6_2.Models
{
    public class Order
    {
       
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public int OrderId { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
       

    }
}