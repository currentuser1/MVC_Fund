using MVC_Fund6_0.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund6_0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User incomingData)
        {
            Debug.WriteLine("Id = " + incomingData.Id);
            Debug.WriteLine("Name = " + incomingData.Name);
            Debug.WriteLine("Surname = " + incomingData.Surname);

            return View();
        }

    }
}