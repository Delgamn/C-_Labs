using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LS.DAL;
using LS.Models;

namespace LS.Controllers
{
    public class OrderController : Controller
    {
        private readonly Repository<Order> Order;
        private readonly Repository<Car> Car;
        private readonly Repository<Client> Client;

        public OrderController()
        {
            Order = new Repository<Order>(new LSContext());
            Car = new Repository<Car>(new LSContext());
            Client = new Repository<Client>(new LSContext());
        }
        public ActionResult Index()
        {
            var order = Order.GetAll().Include(c => c.Car).Include(c => c.Client).ToList();
            return View(order);
        }

        // GET: Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = Order.GetAll().Include(m => m.Workers).SingleOrDefault(m => m.OrderId == id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(Car.GetAll(), "CarId", "Brand");
            ViewBag.ClientId = new SelectList(Client.GetAll(), "ClientId", "Brand");
            return View();
        }

        // POST: Order/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,Date,Status,ClientId,CarId")] Order order)
        {
            if (ModelState.IsValid)
            {
                Order.Insert(order);
                Order.Save();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(Car.GetAll(), "CarId", "Brand", order.CarId);
            ViewBag.ClientId = new SelectList(Client.GetAll(), "ClientId", "Brand", order.ClientId);
            return View(order);
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = Order.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(Car.GetAll(), "CarId", "Brand", order.CarId);
            ViewBag.ClientId = new SelectList(Client.GetAll(), "ClientId", "Brand", order.ClientId);
            return View(order);
        }

        // POST: Order/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,Date,Status,ClientId,CarId")] Order order)
        {
            if (ModelState.IsValid)
            {
                Order.Update(order);
                Order.Save();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(Car.GetAll(), "CarId", "Brand", order.CarId);
            ViewBag.ClientId = new SelectList(Client.GetAll(), "ClientId", "Brand", order.ClientId);
            return View(order);
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = Order.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order.Delete(id);
            Order.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Order.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
