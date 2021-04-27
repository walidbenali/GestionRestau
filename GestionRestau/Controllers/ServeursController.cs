using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionRestau.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionRestau.Controllers
{
    public class ServeursController : Controller
    {
        private readonly IServeurRepository _serveurRepository;
        public ServeursController(IServeurRepository serveurRepository)
        {
            _serveurRepository = serveurRepository;
        }
        // GET: Serveurs
        public ActionResult Index()
        {
            var serveurs = _serveurRepository.GetAll();
            return View(serveurs);
        }

        // GET: Serveurs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Serveurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Serveurs/Create
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

        // GET: Serveurs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Serveurs/Edit/5
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

        // GET: Serveurs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Serveurs/Delete/5
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