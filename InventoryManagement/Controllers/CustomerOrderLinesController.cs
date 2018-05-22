using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    public class CustomerOrderLinesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CustomerOrderLines
        public ActionResult Index()
        {
            var customerOrderLines = db.CustomerOrderLines.Include(c => c.Article).Include(c => c.CustomerOrder);
            return View(customerOrderLines.ToList());
        }

        // GET: CustomerOrderLines/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerOrderLine customerOrderLine = db.CustomerOrderLines.Find(id);
            if (customerOrderLine == null)
            {
                return HttpNotFound();
            }
            return View(customerOrderLine);
        }

        // GET: CustomerOrderLines/Create
        public ActionResult Create()
        {
            ViewBag.ArticleId = new SelectList(db.Articles, "Id", "Name");
            ViewBag.CustomerOrderId = new SelectList(db.CustomerOrders, "Id", "Code");
            return View();
        }

        // POST: CustomerOrderLines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ArticleId,CustomerOrderId")] CustomerOrderLine customerOrderLine)
        {
            if (ModelState.IsValid)
            {
                db.CustomerOrderLines.Add(customerOrderLine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArticleId = new SelectList(db.Articles, "Id", "Name", customerOrderLine.ArticleId);
            ViewBag.CustomerOrderId = new SelectList(db.CustomerOrders, "Id", "Code", customerOrderLine.CustomerOrderId);
            return View(customerOrderLine);
        }

        // GET: CustomerOrderLines/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerOrderLine customerOrderLine = db.CustomerOrderLines.Find(id);
            if (customerOrderLine == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArticleId = new SelectList(db.Articles, "Id", "Name", customerOrderLine.ArticleId);
            ViewBag.CustomerOrderId = new SelectList(db.CustomerOrders, "Id", "Code", customerOrderLine.CustomerOrderId);
            return View(customerOrderLine);
        }

        // POST: CustomerOrderLines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ArticleId,CustomerOrderId")] CustomerOrderLine customerOrderLine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerOrderLine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArticleId = new SelectList(db.Articles, "Id", "Name", customerOrderLine.ArticleId);
            ViewBag.CustomerOrderId = new SelectList(db.CustomerOrders, "Id", "Code", customerOrderLine.CustomerOrderId);
            return View(customerOrderLine);
        }

        // GET: CustomerOrderLines/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerOrderLine customerOrderLine = db.CustomerOrderLines.Find(id);
            if (customerOrderLine == null)
            {
                return HttpNotFound();
            }
            return View(customerOrderLine);
        }

        // POST: CustomerOrderLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CustomerOrderLine customerOrderLine = db.CustomerOrderLines.Find(id);
            db.CustomerOrderLines.Remove(customerOrderLine);
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
