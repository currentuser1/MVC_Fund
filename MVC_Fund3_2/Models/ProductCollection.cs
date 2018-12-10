using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Fund3_2.Models
{
    public class ProductCollection
    {
        public static List<Product> All
        {
            get
            {
                List<Product> products = new List<Product>();
                for (int i = 0; i < 20; i++)
                {
                    products.Add(new Product()
                    {
                        Id = i + 1,
                        Name = "Item Name " + i,
                        Price = (i + 1) * 2,
                        CreatedDate = DateTime.Now
                    });
                }
                return products;
            }
        }
    }
}