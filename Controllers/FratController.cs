using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;
using Airborne.Commander.AspNetCore.ViewModels;

namespace Airborne.Commander.AspNetCore.Controllers
{
    public class FratController : Controller
    {
        private readonly IFratRepository _fratRepository;

        public FratController(IFratRepository fratRepository)
        {
            _fratRepository = fratRepository;
        }

        // GET: Frat
        public ActionResult Index()
        {
            var frats = _fratRepository.Frats;

            return View(frats);
        }

        // GET: Frat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Frat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Frat/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FratViewModel newFrat)
        {
            try
            {
                // include the Static Frat from the ViewModel in the newly created Frat
                newFrat.Frat.StaticFrat = new List<StaticFrat>() { newFrat.StaticFrat };
                _fratRepository.Add(newFrat.Frat);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Frat/Edit/5
        public ActionResult Edit(int id)
        {
            var editFrat = _fratRepository.GetFratById(id);
            var fratViewModel = new FratViewModel();
            fratViewModel.Frat = editFrat;
            fratViewModel.StaticFrat = editFrat.StaticFrat.FirstOrDefault();

            return View(fratViewModel);
        }

        // POST: Frat/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FratViewModel fratViewModel)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _fratRepository.Update(fratViewModel.Frat);
                    _fratRepository.Update(fratViewModel.StaticFrat);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(fratViewModel);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Frat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Frat/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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