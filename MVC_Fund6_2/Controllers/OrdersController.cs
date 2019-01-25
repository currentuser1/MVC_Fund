
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MVC_Fund6_2.Models;

namespace MVC_Fund6_2.Controllers
{
    public class OrdersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Orders
        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Customer).Include(o => o.Product);
            return View(orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name");
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name");
            return View();
        }

        // POST: Orders/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,CustomerId,ProductId,Count,Date")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", order.ProductId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", order.ProductId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,CustomerId,ProductId,Count,Date")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", order.ProductId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Report()
        {

            return View();
        }
        //[HttpPost]
        //public ActionResult Report(ReportModel incomingData)
        //{
        //    int count;
        //    if (incomingData.StartDate != null && incomingData.EndDate != null)
        //    {
        //        count = (from x in db.Orders where (x.Date >= incomingData.StartDate && x.Date <= incomingData.EndDate) select x).Count();
        //    }
        //    else count = 0;
        //    ViewBag.Count = count;
        //    decimal? result;
        //    if (incomingData.StartDate != null && incomingData.EndDate != null)
        //    {
        //        result = (from o in db.Orders
        //                  join p in db.Products on o.ProductId equals p.ProductId
        //                  let amount = o.Count * p.Cost
        //                  where (o.Date >= incomingData.StartDate && o.Date <= incomingData.EndDate)
        //                  select amount).DefaultIfEmpty(0).Sum();
        //    }
        //    else result = 0;
        //    ViewBag.Result = result;
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Report(string y)
        //{
        //    var query = from c in db.Customers
        //                join o in db.Orders on c.CustomerId equals o.CustomerId
        //                join p in db.Products on o.ProductId equals p.ProductId
        //                where c.Name == y
        //                select new
        //                {
        //                    c.CustomerId,
        //                    c.Name,
        //                    c.Surname,
        //                    Product = p.Name,
        //                    p.Cost,
        //                    c = o.Count,
        //                    d = o.Date
        //                };
        //    ViewBag.Query = query.ToList();
        //    return View();
        //}




        [HttpPost]
        public ActionResult Report(ReportModel incomingData)
        {
            Debug.WriteLine("StartDate = " + incomingData.StartDate);
            Debug.WriteLine("EndDate = " + incomingData.EndDate);
            int count;
            if (incomingData.StartDate != null && incomingData.EndDate != null)
            {
                count = (from x in db.Orders where (x.Date >= incomingData.StartDate && x.Date <= incomingData.EndDate) select x).Count();
            }
            else count = 0;
            ViewBag.Count = count;
            decimal? result;
            if (incomingData.StartDate != null && incomingData.EndDate != null)
            {
                result = (from o in db.Orders
                          join p in db.Products on o.ProductId equals p.ProductId
                          let amount = o.Count * p.Cost
                          where (o.Date >= incomingData.StartDate && o.Date <= incomingData.EndDate)
                          //select p.Cost;
                          select amount).DefaultIfEmpty(0).Sum();
            }
            else result = 0;
            ViewBag.Result = result;
            //  Debug.WriteLine("y = " + y);

            /*select t1.CustomerId,t1.Name,t1.Surname,t3.Name as Product,t3.Cost,t2.Count,t2.Date from DatabaseContext.dbo.Customers as t1 
             INNER JOIN DatabaseContext.dbo.Orders as t2 ON t1.CustomerId=t2.CustomerId INNER JOIN DatabaseContext.dbo.Products as t3 ON t2.ProductId=t3.ProductId*/
            return View();
        }

        public ActionResult Statistic()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Statistic(string y)
        {
            var query = (from c in db.Customers.AsEnumerable()
                         join o in db.Orders.AsEnumerable() on c.CustomerId equals o.CustomerId//////
                         join p in db.Products.AsEnumerable() on o.ProductId equals p.ProductId //
                         where c.Name == y
                         select new X
                         {
                             CustomerId = c.CustomerId,
                             Name = c.Name,
                             Surname = c.Surname,
                             Product = p.Name,
                             Cost = p.Cost,
                             Count = o.Count,
                             Date = o.Date
                         }).ToList();
            return View("Succes", query);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
