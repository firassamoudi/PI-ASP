using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoXam.Web.Controllers
{
    public class RisqueController : Controller
    {
        // GET: Risque
        public ActionResult Index()
        {
            return View();
        }

        // GET: Risque/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Risque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Risque/Create
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

        // GET: Risque/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Risque/Edit/5
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

        // GET: Risque/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Risque/Delete/5
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
