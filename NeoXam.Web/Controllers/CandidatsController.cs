using NeoXam.Service.Recrutement;
using System;
using NeoXam.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace NeoXam.Web.Controllers
{
    public class CandidatsController : Controller
    {
        CandidatService service = new CandidatService();
        // GET: Candidats
        public ActionResult Index()
        {
            return View(service.GetMany().ToList());
        }
        // GET: Candidats/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Candidats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Candidats/Create
        [HttpPost]
        
        public ActionResult Create([Bind(Include = "CIN,adresse,Email,linkedin,Nom,numTel,Prenom,resume")] candidat candidat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.Add(candidat);
                    service.Commit();
                    return RedirectToAction("Index");
                }
                return View(candidat);

            }
            catch
            {
                return View();
            }
        }

        // GET: Candidats/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Candidats/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Candidats/Delete/5
        public ActionResult Delete(string id)
        {            
            service.Delete(service.GetById(id));
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            candidat candidat = service.GetById(id);
            if (candidat == null)
            {
                return HttpNotFound();
            }
            return View(candidat);
        }

        // POST: Candidats/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
                candidat candidat = service.GetById(id);
                service.Delete(candidat);
                service.Commit();
            return RedirectToAction("Index");
        }        
    }
}
