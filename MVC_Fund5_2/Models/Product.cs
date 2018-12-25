using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Fund5_2.Models
{
    public  class ProductDatabase
    {
       // private static List<Product> _products;

        public static List<Product> Products
        {
            get
            {
                // if (_products == null)
                //  {
                   // _products = new List<Product>();
                    Product info = new Product();

                    info.ID = 1;
                    info.Name = "Butter";
                    info.Price = 10;
                    info.Description = "blablabutter";
                    Products.Add(info);

                    info = new Product();
                    info.ID = 2;
                    info.Name = "Broad";
                    info.Price = 20;
                    info.Description = "blablabroad";
                Products.Add(info);

                    info = new Product();
                    info.ID = 3;
                    info.Name = "Oil";
                    info.Price = 30;
                    info.Description = "blablaoil";
                Products.Add(info);

                    info = new Product();
                    info.ID = 4;
                    info.Name = "Milk";
                    info.Price = 40;
                    info.Description = "blablamilk";
                Products.Add(info);

                    info = new Product();
                    info.ID = 5;
                    info.Name = "tomato";
                    info.Price = 50;
                    info.Description = "blablatomato";
                Products.Add(info);
               // }
                return Products;
            }
        }

    }











        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Description { get; set; }
        }
    }

}