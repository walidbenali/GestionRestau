using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionRestau.Models;
using GestionRestau.Repositories.Interfaces;
using GestionRestau.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionRestau.Controllers
{
    public class TableCmdsController : Controller
    {
        private readonly ITableCmdRepository _tableCmdRepository;
        private readonly IServeurRepository _serveurRepository;
        public TableCmdsController(ITableCmdRepository tableCmdRepository,IServeurRepository serveurRepository)
        {
            _tableCmdRepository = tableCmdRepository;
            _serveurRepository = serveurRepository;
        }
        // GET: TableCmds
        public ActionResult Index()
        {   
            var tableCmds = _tableCmdRepository.GetAllWithServers();

            var tableOccupees = tableCmds.Where(tbl => tbl.Occupation == true).Count();
            ViewData["tableOccupees"] = tableOccupees;
            ViewBag.tableocc = tableOccupees;
            var tableLibres = tableCmds.Where(tbl => tbl.Occupation == false).Count();
            ViewData["tableLibres"] = tableLibres;

            return View(tableCmds);
        }

        // GET: TableCmds/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: TableCmds/Create
        public ActionResult Create()
        {
            TableCmdViewModel tableCmdViewModel = new TableCmdViewModel();
            tableCmdViewModel.Serveurs = _serveurRepository.GetAll()
                .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Nom}).ToList();

            return View(tableCmdViewModel);
        }

        // POST: TableCmds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TableCmdViewModel tableCmds)
        {
            try  
            {
                TableCmd tbl = new TableCmd();
                tbl.Id = tableCmds.Id;
                tbl.Numero = tableCmds.Numero;
                tbl.NbPlace = tableCmds.NbPlace;
                tbl.Occupation = tableCmds.Occupation;
                tbl.Emplacement = tableCmds.Emplacement;
                tbl.ServeurId = tableCmds.ServeurId; 
                _tableCmdRepository.Insert(tbl);
                _serveurRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TableCmds/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TableCmds/Edit/5
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

        // GET: TableCmds/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TableCmds/Delete/5
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