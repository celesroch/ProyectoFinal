using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace ProyectoFinal.Controllers
{
    public class OperacionesController : Controller
    {
        private AlquilerLibrosEntities db = new AlquilerLibrosEntities();

        // GET: Operaciones
        public ActionResult Index()
        {
            return View(db.Operaciones.ToList());
        }

        // GET: Operaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operaciones operaciones = db.Operaciones.Find(id);
            if (operaciones == null)
            {
                return HttpNotFound();
            }
            return View(operaciones);
        }

        // GET: Operaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Operaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCliente,idLibro,estado,fecha")] Operaciones operaciones)
        {
            if (ModelState.IsValid)
            {
                db.Operaciones.Add(operaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operaciones);
        }

        // GET: Operaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operaciones operaciones = db.Operaciones.Find(id);
            if (operaciones == null)
            {
                return HttpNotFound();
            }
            return View(operaciones);
        }

        // POST: Operaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCliente,idLibro,estado,fecha")] Operaciones operaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operaciones);
        }

        // GET: Operaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operaciones operaciones = db.Operaciones.Find(id);
            if (operaciones == null)
            {
                return HttpNotFound();
            }
            return View(operaciones);
        }

        // POST: Operaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Operaciones operaciones = db.Operaciones.Find(id);
            db.Operaciones.Remove(operaciones);
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
