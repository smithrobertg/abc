using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public interface IAlert
    {
        DateTimeOffset CreatedDate { get; set; }
        string Description { get; set; }
        bool AircraftGrounded { get; set; }
        DateTimeOffset AircraftGroundedDate { get; set; }
        string ShortDescription(int length);
    }
}
