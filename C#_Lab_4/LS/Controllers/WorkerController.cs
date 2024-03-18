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
    public class WorkerController : Controller
    {
        private readonly Repository<Worker> Worker;

        // GET: Client
        public WorkerController()
        {
            Worker = new Repository<Worker>(new LSContext());
        }

        // GET: Worker
        public ActionResult Index()
        {
            return View(Worker.GetAll());
        }

        // GET: Worker/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = Worker.GetAll().Include(m => m.Orders).SingleOrDefault(m => m.WorkerId == id);
            if (worker == null)
            {
                return HttpNotFound();
            }
            return View(worker);
        }

        // GET: Worker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Worker/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkerId,Name,Position,Salary")] Worker worker)
        {
            if (ModelState.IsValid)
            {
                Worker.Insert(worker);
                Worker.Save();
                return RedirectToAction("Index");
            }

            return View(worker);
        }

        // GET: Worker/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = Worker.GetById(id);
            if (worker == null)
            {
                return HttpNotFound();
            }
            return View(worker);
        }

        // POST: Worker/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkerId,Name,Position,Salary")] Worker worker)
        {
            if (ModelState.IsValid)
            {
                Worker.Update(worker);
                Worker.Save();
                return RedirectToAction("Index");
            }
            return View(worker);
        }

        // GET: Worker/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = Worker.GetById(id);
            if (worker == null)
            {
                return HttpNotFound();
            }
            return View(worker);
        }

        // POST: Worker/Delete/5
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
                Worker.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
