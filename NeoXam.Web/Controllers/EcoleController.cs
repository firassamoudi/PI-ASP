using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoXam.Web.Controllers
{
    public class EcoleController : Controller
    {
        // GET: Ecole
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ecole/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ecole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ecole/Create
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

        // GET: Ecole/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ecole/Edit/5
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

        // GET: Ecole/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ecole/Delete/5
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
