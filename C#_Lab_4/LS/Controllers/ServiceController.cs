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
    public class ServiceController : Controller
    {
        private readonly Repository<Service> Service;
        private readonly Repository<Worker> Worker;

		public ServiceController()
		{
			Service = new Repository<Service>(new LSContext());
            Worker = new Repository<Worker>(new LSContext());
        }

        // GET: Service
        public ActionResult Index()
        {
            var services = Service.GetAll().Include(s => s.Worker);
            return View(services.ToList());
        }

        // GET: Service/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = Service.GetById(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // GET: Service/Create
        public ActionResult Create()
        {
            ViewBag.WorkerId = new SelectList(Worker.GetAll(), "WorkerId", "Name");
            return View();
        }

        // POST: Service/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceId,Name,Cost,WorkerId")] Service service)
        {
            if (ModelState.IsValid)
            {
                Service.Insert(service);
                Service.Save();
                return RedirectToAction("Index");
            }

            ViewBag.WorkerId = new SelectList(Worker.GetAll(), "WorkerId", "Name", service.WorkerId);
            return View(service);
        }

        // GET: Service/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = Service.GetById(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            ViewBag.WorkerId = new SelectList(Worker.GetAll(), "WorkerId", "Name", service.WorkerId);
            return View(service);
        }

        // POST: Service/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceId,Name,Cost,WorkerId")] Service service)
        {
            if (ModelState.IsValid)
            {
                Service.Update(service);
                Service.Save();
                return RedirectToAction("Index");
            }
            ViewBag.WorkerId = new SelectList(Worker.GetAll(), "WorkerId", "Name", service.WorkerId);
            return View(service);
        }

        // GET: Service/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = Service.GetById(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // POST: Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Worker.Delete(id);
            Worker.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
