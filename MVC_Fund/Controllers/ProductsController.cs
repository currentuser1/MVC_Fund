using MVC_Fund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Книга интересная",
                Description = "Очень интересная кника",
                Price = 3m
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Бумага A4",
                Description = "Очень плохая бумага",
                Price = 15m,

            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Мобильный телефон",
                Description = "Раскладушка",
                Price = 250m,
            });

            // Возвращаем представление из директории Views/Products/Index.cshtml
            // Параметр передающийся в метод View() является моделью, которая будет доступна только на чтение в представлении Index
            return View(products);
        }
    }
}