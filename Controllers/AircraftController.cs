using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Controllers
{
    public class AircraftController : Controller
    {
        private readonly IAircraftRepository _aircraftRepository;
        private readonly IMissionRepository _missionRepository;

        public AircraftController(IAircraftRepository aircraftRepository, IMissionRepository missionRepository)
        {
            _aircraftRepository = aircraftRepository;
            _missionRepository = missionRepository;
        }

        public ViewResult List()
        {
            return View(_aircraftRepository.Aircrafts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _aircraftRepository.Add(aircraft);
                return RedirectToAction("Index");

            }
            return View(aircraft);
        }

        public IActionResult Update()
        {
            int aircraftId;
            int.TryParse(RouteData.Values["id"].ToString(), out aircraftId);
            var aircraft = _aircraftRepository.GetAircraftById(aircraftId);

            return View(aircraft);
        }

        [HttpPost]
        public IActionResult Update(Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _aircraftRepository.Update(aircraft);
                return RedirectToAction("Index");
            }
            return View(aircraft);
        }


        // GET: /<controller>/
        public ViewResult Index()
        {
            return View(_aircraftRepository.Aircrafts);
        }
    }
}
