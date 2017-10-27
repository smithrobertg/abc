using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;
using Airborne.Commander.AspNetCore.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Airborne.Commander.AspNetCore.Controllers
{
    public class MissionController : Controller
    {
        private readonly IMissionRepository _missionRepository;
        private readonly IAircraftRepository _aircraftRepository;

        public MissionController(IMissionRepository missionRepository, IAircraftRepository aircraftRepository)
        {
            _missionRepository = missionRepository;
            _aircraftRepository = aircraftRepository;
        }

        public ViewResult List()
        {
            var missionListViewModel = new MissionListViewModel();
            missionListViewModel.Missions = _missionRepository.Missions;
            missionListViewModel.MissionTitle = "AIRBORNE COMMANDER - AIRWING";

            return View(missionListViewModel);
        }

        public IActionResult NewMission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMission(Mission mission)
        {
            if (ModelState.IsValid)
            {
                _missionRepository.AddMission(mission);
                return RedirectToAction("Index");
            }
            return View(mission);
        }

        public IActionResult Update()
        {
            int missionId;
            int.TryParse(this.RouteData.Values["id"].ToString(), out missionId);
            var mission = _missionRepository.GetMissionById(missionId);

            return View(mission);
        }

        [HttpPost]
        public IActionResult Update(Mission mission)
        {
            if (ModelState.IsValid)
            {
                _missionRepository.Update(mission);
                return RedirectToAction("Index");
            }
            return View(mission);
        }

        //DANGER:  Performing Delete action on GET request opens a security hole.
        //         This should be routed to a POST action confirmation view.
        public IActionResult Delete()
        {
            int missionId;
            int.TryParse(this.RouteData.Values["id"].ToString(), out missionId);
            var mission = _missionRepository.GetMissionById(missionId);
            _missionRepository.Delete(mission);

            return RedirectToAction("Index");
        }

        public IActionResult Form()
        {
            return View(_missionRepository.Missions.FirstOrDefault());
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_missionRepository.Missions);
        }
    }
}
