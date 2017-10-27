using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.Components
{
    public class ReadBeforeFlight : ViewComponent
    {
        private readonly IRbfRepository _rbfRepository;

        public ReadBeforeFlight(IRbfRepository rbfRepository)
        {
            _rbfRepository = rbfRepository;
        }

        public IViewComponentResult Invoke()
        {
            var rbfs = _rbfRepository.Rbfs;

            return View(rbfs);
        }
    }
}
