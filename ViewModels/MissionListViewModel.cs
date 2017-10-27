using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.ViewModels
{
    public class MissionListViewModel
    {
        public IEnumerable<Mission> Missions { get; set; }
        public string MissionTitle { get; set; }
    }
}
