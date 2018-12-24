using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fund5_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost] // метод будет вызываться только при POST запросах
        public ActionResult Login(string login, string password)
        {
            string name = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "Login.txt");



            FileInfo info = new FileInfo(name);

            using (StreamWriter writer = info.CreateText())
            {
                writer.WriteLine(login);
                writer.WriteLine(password);

            }


            return File(name, "text/plain");
        }
        public ActionResult Registration()
        {

            return View();
        }
        [HttpPost]

        public ActionResult Registration(string login, string password, string repeatpassword, string email)
        {
            string name = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "Registration.txt");



            FileInfo info = new FileInfo(name);

            using (StreamWriter writer = info.CreateText())
            {
                writer.WriteLine(login);
                writer.WriteLine(password);
                writer.WriteLine(repeatpassword);
                writer.WriteLine(email); //

            }


            return File(name, "text/plain");
        }


    }
}