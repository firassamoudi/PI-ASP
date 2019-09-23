using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NeoXam.Web.Models;

namespace NeoXam.Web.Controllers
{
    public class contratsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: contrats
        public ActionResult Index()
        {
            var contrats = db.contrats.Include(c => c.salaire).Include(c => c.employe);
          
            return View(contrats.ToList());
        }

        // GET: contrats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contrat contrat = db.contrats.Find(id);
            if (contrat == null)
            {
                return HttpNotFound();
            }
            return View(contrat);
        }

        // GET: contrats/Create
        public ActionResult Create()
        {
            ViewBag.idSalaire = new SelectList(db.salaires, "idSalaire", "idSalaire");
            return View();
        }

        // POST: contrats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idContrat,DateDep,DateFin,Type,idEmploye,idSalaire")] contrat contrat)
        {
            if (ModelState.IsValid)
            {
                db.contrats.Add(contrat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idSalaire = new SelectList(db.salaires, "idSalaire", "idSalaire", contrat.idSalaire);
            return View(contrat);
        }

        // GET: contrats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contrat contrat = db.contrats.Find(id);
            if (contrat == null)
            {
                return HttpNotFound();
            }
            ViewBag.idSalaire = new SelectList(db.salaires, "idSalaire", "idSalaire", contrat.idSalaire);
            return View(contrat);
        }

        // POST: contrats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idContrat,DateDep,DateFin,Type,idEmploye,idSalaire")] contrat contrat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contrat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idSalaire = new SelectList(db.salaires, "idSalaire", "idSalaire", contrat.idSalaire);
            return View(contrat);
        }

        // GET: contrats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contrat contrat = db.contrats.Find(id);
            if (contrat == null)
            {
                return HttpNotFound();
            }
            return View(contrat);
        }

        // POST: contrats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contrat contrat = db.contrats.Find(id);
            db.contrats.Remove(contrat);
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
