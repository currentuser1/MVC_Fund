using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }

    public static class ProductDatabase
    {
        public static List<Product> products; //field
        public static List<Product> Products // property
        {
            get
            {

                products = new List<Product>();
                Product info = new Product();
                info.ID = 1;
                info.Name = "Butter";
                info.Price = 10;
                info.Description = "blablabutter";
                products.Add(info);
                return products;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine(Products.Count);
            }
        }
    }
}