using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Components
{
    public class MissionSummary : ViewComponent
    {
        private readonly IMissionRepository _missionRepository;

        public MissionSummary(IMissionRepository missionRepository)
        {
            _missionRepository = missionRepository;
        }

        public IViewComponentResult Invoke()
        {
            var missions = _missionRepository.Missions;
            //var missions = new List<Mission> { new Mission() };   // test component - 1 mission
            //var missions = new List<Mission>();  // test component- no missions

            return View(missions);
        }
    }
}
