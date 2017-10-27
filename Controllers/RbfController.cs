using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airborne.Commander.AspNetCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airborne.Commander.AspNetCore.Controllers
{
    public class RbfController : Controller
    {
        private readonly IRbfRepository _rbfRepository;

        public RbfController(IRbfRepository rbfRepository)
        {
            _rbfRepository = rbfRepository;
        }

        // GET: /Rbf/Read/Id
        public IActionResult Read(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rbf = _rbfRepository.GetRbf(id.Value);

            if (rbf == null)
            {
                return NotFound();
            }

            return View(rbf);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_rbfRepository.Rbfs);
        }
    }
}
