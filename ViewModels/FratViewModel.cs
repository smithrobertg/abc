using Airborne.Commander.AspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.ViewModels
{
    public class FratViewModel
    {
        public Frat Frat { get; set; }
        public StaticFrat StaticFrat { get; set; }
    }
}
