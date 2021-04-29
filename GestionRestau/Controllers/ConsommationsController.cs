using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionRestau.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionRestau.Controllers
{
    public class ConsommationsController : Controller
    {
        private readonly IConsommationRepository _consommationRepository;
        public ConsommationsController(IConsommationRepository consommationRepository)
        {
            _consommationRepository = consommationRepository;
        }
        // GET: Consommations
        public ActionResult Index()
        {
            var consommations = _consommationRepository.GetAll();
            return View(consommations);
        }

        // GET: Consommations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Consommations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consommations/Create
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

        // GET: Consommations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Consommations/Edit/5
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

        // GET: Consommations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Consommations/Delete/5
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