using System.Linq;
using System.Web.Mvc;
using MVC_Fund6_2.Models;
using System.Data.Entity;

namespace MVC_Fund6_2.Controllers
{
    public class testController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: test
        public ActionResult Statistic()
        {
            var query = (from c in db.Customers.AsEnumerable()
                        join o in db.Orders.AsEnumerable() on c.CustomerId equals o.CustomerId//////
                        join p in db.Products.AsEnumerable() on o.ProductId equals p.ProductId //
                        where c.Name == "Mikhail"
                         select new SalesViewModel
                         {
                           CustomerId= c.CustomerId, 
                           Name = c.Name,
                           Surname= c.Surname,
                           Product=p.Name,
                           Cost= p.Cost,
                           Count= o.Count,
                           Date= o.Date
                        }).ToList();
            return View(query);
        }
    }
}