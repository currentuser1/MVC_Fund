using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVC_Fund6_2.Models
{
    public class X
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Product { get; set; }
        public decimal Cost { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
    }
}