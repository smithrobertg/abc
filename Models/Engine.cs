using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class Engine
    {
        public int EngineId { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double TotalTime { get; set; }
        public double NgCycles { get; set; }
        public double NpNf { get; set; }
        public int Flights { get; set; }
    }
}
