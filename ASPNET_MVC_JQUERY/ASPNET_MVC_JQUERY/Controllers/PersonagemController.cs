using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_JQUERY.Controllers
{
    public class PersonagemController : Controller
    {
        // GET: Personagem
        public ActionResult Index()
        {
            return View();
        }

        // GET: Personagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personagem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personagem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personagem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personagem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}