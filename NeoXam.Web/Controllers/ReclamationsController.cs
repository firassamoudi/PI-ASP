using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoXam.Web.Controllers
{
    public class ReclamationsController : Controller
    {
        // GET: Reclamations
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reclamations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reclamations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reclamations/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reclamations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reclamations/Edit/5
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

        // GET: Reclamations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reclamations/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
