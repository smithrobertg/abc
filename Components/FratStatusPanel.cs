using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Components
{
    public class FratStatusPanel : ViewComponent
    {
        private readonly IFratRepository _fratRepository;

        public FratStatusPanel(IFratRepository fratRepository)
        {
            _fratRepository = fratRepository;
        }

        public IViewComponentResult Invoke()
        {
            var frats = _fratRepository.Frats;

            return View(frats);
        }
    }
}
