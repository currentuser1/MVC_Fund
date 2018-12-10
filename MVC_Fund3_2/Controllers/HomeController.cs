using MVC_Fund3_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund3_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowTable(int numberOfRows = 5)
        {
            IEnumerable<Product> products = ProductCollection.All.Take(numberOfRows);
            return View(products);
        }


    }
}