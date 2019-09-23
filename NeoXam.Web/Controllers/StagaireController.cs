using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoXam.Web.Controllers
{
    public class StagaireController : Controller
    {
        // GET: Stagaire
        public ActionResult Index()
        {
            return View();
        }

        // GET: Stagaire/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stagaire/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stagaire/Create
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

        // GET: Stagaire/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stagaire/Edit/5
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

        // GET: Stagaire/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stagaire/Delete/5
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
