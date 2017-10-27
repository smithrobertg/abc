using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public interface IAircraftRepository
    {
        IEnumerable<Aircraft> Aircrafts { get; }
        Aircraft GetAircraftById(int aircraftId);
        void Add(Aircraft aircraft);
        void Update(Aircraft aircraft);
    }
}
