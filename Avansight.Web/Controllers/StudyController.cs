using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avansight.Web.Controllers
{
    public class StudyController : Controller
    {
        // GET: StudyController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
