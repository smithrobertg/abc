using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;
using Airborne.Commander.AspNetCore.ViewModels;

namespace Airborne.Commander.AspNetCore.Controllers
{
    public class RosterController : Controller
    {
        public IActionResult Index()
        {
            var todaysRoster = new RosterViewModel();

            todaysRoster.RosterDate = DateTime.Today;
            todaysRoster.RosterEntries = new List<RosterEntry>();

            return View(todaysRoster);
        }
    }
}