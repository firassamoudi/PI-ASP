using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoXam.Web.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace NeoXam.Web.Controllers
{
    public class SalaireController : Controller
    {
        // GET: Salaire
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("http://localhost:18080/NeoXamPiDev-web/rest/salaires").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<Models.salaire>>().Result;

            }

            else
            {
                ViewBag.result = "error";
            }
            return View(ViewBag.result);
        }

        // GET: Salaire/Details/5
        public ActionResult Details(int id)
        {
            Models.salaire salaire1 = null;

            HttpClient Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("http://localhost:18080/NeoXamPiDev-web/rest/salaires/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                salaire1 = response.Content.ReadAsAsync<Models.salaire>().Result;

            }

            else
            {
                ViewBag.result = "error";
            }



            return View(salaire1);
        }

        // GET: Salaire/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salaire/Create
        [HttpPost]
        public ActionResult Create(salaire salaire)
        {
            try
            {

                HttpClient Client = new HttpClient();
                HttpResponseMessage response = Client.PostAsJsonAsync<salaire>("localhost:18080/NeoXamPiDev-web/rest/salaires", salaire).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;

                if (response.IsSuccessStatusCode)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Salaire/Edit/5
        public ActionResult Edit(int id)
        {
            Models.salaire salaire = null;

            HttpClient Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("localhost:18080/NeoXamPiDev-web/rest/salaires/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                salaire = response.Content.ReadAsAsync<Models.salaire>().Result;

            }

            else
            {
                ViewBag.result = "error";
            }



            return View(salaire);
        }

        // POST: Salaire/Edit/5
        [HttpPost]
        public ActionResult Edit(salaire salaire)
        {
            try
            {

                HttpClient Client = new HttpClient();
                HttpResponseMessage response = Client.PutAsJsonAsync<salaire>("localhost:18080/NeoXamPiDev-web/rest/salaires", salaire).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;

                if (response.IsSuccessStatusCode)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Salaire/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salaire/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = Client.DeleteAsync("localhost:18080/NeoXamPiDev-web/rest/salaires/" + id).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
