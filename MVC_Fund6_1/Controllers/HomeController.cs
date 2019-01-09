using MVC_Fund6_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund6_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {



            User user = new User();

            user.CodeCountry = "+7";
            user.CodeUser = "123456789";

            user.CodeCity = CityCode.one;




            return View(user);

        }

    }
}