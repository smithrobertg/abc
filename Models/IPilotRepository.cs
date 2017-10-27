using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    interface IPilotRepository
    {
        IEnumerable<Pilot> Pilots { get; }
        Pilot GetPilotById(int pilotId);
    }
}
