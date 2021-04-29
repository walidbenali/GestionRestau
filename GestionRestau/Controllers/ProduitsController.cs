using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionRestau.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionRestau.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly IProduitRepository _produitRepository;
        public ProduitsController(IProduitRepository produitRepository)
        {
            _produitRepository = produitRepository;
        }
        // GET: Produits
        public ActionResult Index()
        {
            var produits = _produitRepository.GetAll();
            return View(produits);
        }

        // GET: Produits/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produits/Create
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

        // GET: Produits/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produits/Edit/5
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

        // GET: Produits/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produits/Delete/5
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