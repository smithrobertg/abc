using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.ViewModels
{
    public class RosterViewModel
    {
        public DateTime RosterDate { get; set; }
        public IList<RosterEntry> RosterEntries { get; set; }
    }
}
