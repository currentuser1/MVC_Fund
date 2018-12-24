
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund5_0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int x, int y,string Calc)
        {

            switch (Calc)
            {
                case "+":
                    ViewBag.Result= x + y;
                    break;
                case "-":
                    ViewBag.Result = x - y;
                    break;
                case "*":
                    ViewBag.Result = x * y;
                    break;
                case "/":
                    ViewBag.Result = x / y;
                    break;

            }
            return View();
        }

    }
}