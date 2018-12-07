using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund2.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Add(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x + y;
                ViewBag.Name = "Add";
            }
            return View();
        }
        public ActionResult Mul(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x * y;
                ViewBag.Name = "Mul";

            }
            return View("Add");
        }
        public ActionResult Sub(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x - y;
                ViewBag.Name = "Sub";
            }
            return View("Add");
        }
        public ActionResult Div(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x / y;
                ViewBag.Name = "Div";
            }
            return View("Add");
        }
    }
}