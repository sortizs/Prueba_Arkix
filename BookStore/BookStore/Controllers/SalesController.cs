using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class SalesController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: Sales
        //public ActionResult Index()
        //{
        //    var sale = db.Sale.Include(s => s.Book).Include(s => s.Client);
        //    return View(sale.ToList());
        //}

        public ViewResult Index(string clientName, string startDate, string endDate)
        {
            var sale = from s in db.Sale select s;
            if (!String.IsNullOrEmpty(clientName) && !String.IsNullOrEmpty(startDate) && !String.IsNullOrEmpty(endDate))
            {
                var sDate = DateTime.Parse(startDate);
                var eDate = DateTime.Parse(endDate);
                sale = sale.Where(s => s.Client.Name.Contains(clientName) && s.Sale_Date >= sDate && s.Sale_Date <= eDate);
            }

            return View(sale.ToList());
        }

        // GET: Sales/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sale.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Book, "Id", "Title");
            ViewBag.ClientId = new SelectList(db.Client, "Id", "Full_Name");
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClientId,BookId,Sale_Date,Sale_Value,Salesman")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Sale.Add(sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Book, "Id", "Title", sale.BookId);
            ViewBag.ClientId = new SelectList(db.Client, "Id", "Full_Name", sale.ClientId);
            return View(sale);
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sale.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Book, "Id", "Title", sale.BookId);
            ViewBag.ClientId = new SelectList(db.Client, "Id", "Full_Name", sale.ClientId);
            return View(sale);
        }

        // POST: Sales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClientId,BookId,Sale_Date,Sale_Value,Salesman")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Book, "Id", "Title", sale.BookId);
            ViewBag.ClientId = new SelectList(db.Client, "Id", "Full_Name", sale.ClientId);
            return View(sale);
        }

        // GET: Sales/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sale.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Sale sale = db.Sale.Find(id);
            db.Sale.Remove(sale);
            db.SaveChanges();
            return RedirectToAction("Index");
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
