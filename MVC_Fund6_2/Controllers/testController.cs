using System.Linq;
using System.Web.Mvc;
using MVC_Fund6_2.Models;

namespace MVC_Fund6_2.Controllers
{
    public class testController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: test
        public ActionResult Statistic()
        {
            var query = from c in db.Customers
                        join o in db.Orders on c.CustomerId equals o.CustomerId////
                        join p in db.Products on o.ProductId equals p.ProductId //
                        select new
                        {
                            c.CustomerId, //
                            c.Name,
                            c.Surname,
                            Product = p.Name,
                            p.Cost,
                            o.Count,
                            o.Date
                        };
            return View(query.ToList());
        }
    }
}