using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OIDWebManager.Controllers
{
    public class OIDRequestController : Controller
    {
        // GET: OIDRequest
        public ActionResult Index()
        {
            return View();
        }

        // GET: OIDRequest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OIDRequest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OIDRequest/Create
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

        // GET: OIDRequest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OIDRequest/Edit/5
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

        // GET: OIDRequest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OIDRequest/Delete/5
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
