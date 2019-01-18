using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace periodo_academico.Controllers
{
    public class ProvasController : Controller
    {
        // GET: Provas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Provas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Provas/Create
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

        // GET: Provas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
