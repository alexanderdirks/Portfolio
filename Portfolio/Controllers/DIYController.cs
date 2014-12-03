using System.Web.Mvc;
using Portfolio.Models;
using Portfolio.Library;

namespace Portfolio.Controllers
{
    public class DIYController : Controller
    {
        // GET: DIY
        public ActionResult DIY()
        {
            return View();
        }

        // GET: DIY/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DIY/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DIY/Create
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

        // GET: DIY/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DIY/Edit/5
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

        // GET: DIY/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DIY/Delete/5
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
