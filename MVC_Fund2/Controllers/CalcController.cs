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
            }
            return View();
        }
        public ActionResult Mul(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x * y;
            }
            return View("Add");
        }
        public ActionResult Sub(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x - y;
            }
            return View("Add");
        }
        public ActionResult Div(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x / y;
            }
            return View("Add");
        }
    }
}