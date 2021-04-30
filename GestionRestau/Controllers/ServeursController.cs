using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionRestau.Models;
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
            var serveur = _serveurRepository.GetById(id);
            return View(serveur);
        }

        // GET: Serveurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Serveurs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Serveur serveur)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                _serveurRepository.Insert(serveur);
                _serveurRepository.Save();
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
            var serveur = _serveurRepository.GetById(id);
            if (serveur == null) return NotFound();
            return View(serveur);
        }

        // POST: Serveurs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Serveur serveur)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var exist = _serveurRepository.GetById(serveur.Id);
            if (exist==null)
            {
                return NotFound();
            }
            try
            {
                _serveurRepository.Update(serveur);
                _serveurRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
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