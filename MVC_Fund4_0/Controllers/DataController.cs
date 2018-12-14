using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund4_0.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RouteInformation()
        {
            var z = RouteData.Values["id"];
            string x;
            if (z == null) x = "Данные не предоставлены";
            else x = (string)z;
            return Content(x, "text/plain", Encoding.UTF8);
            
        }
    }
}