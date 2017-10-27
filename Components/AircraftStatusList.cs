using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Components
{
    public class AircraftStatusList : ViewComponent
    {
        private readonly IAircraftRepository _aircraftRepository;

        public AircraftStatusList(IAircraftRepository aircraftRepository)
        {
            _aircraftRepository = aircraftRepository;
        }

        public IViewComponentResult Invoke()
        {
            var aircrafts = _aircraftRepository.Aircrafts;

            return View(aircrafts);
        }
    }
}
