using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class MockAircraftRepository : IAircraftRepository
    {
        public IEnumerable<Aircraft> Aircrafts
        {
            get
            {
                var aircrafts = new List<Aircraft>
                {
                     new Aircraft()
                     {
                        AircraftId = 9999,
                        CallSign = "Air 1",
                        TailNumber = "N821SP",
                        Status = "Active",
                        Make = "Airbus Helicopters",
                        Model = "AS-350BA",
                        YearManufactured = 1988,
                        ModeSCode = "52633060",
                        SerialNumber = "2106",
                        AircraftType = AircraftType.Rotorcraft,
                        EngineType = "Turbo-shaft"
                     },

                     new Aircraft()
                     {
                        AircraftId = 8888,
                        CallSign = "Air 2",
                        TailNumber = "N822SP",
                        Status = "Active",
                        Make = "Airbus Helicopters",
                        Model = "AS-350BA",
                        YearManufactured = 1988,
                        ModeSCode = "52633060",
                        SerialNumber = "2107",
                        AircraftType = AircraftType.Rotorcraft,
                        EngineType = "Turbo-shaft"
                     }
                };

                return aircrafts;
            }
        }

        public void Add(Aircraft aircraft)
        {
            return;
        }

        public void Update(Aircraft aircraft)
        {
            return;
        }

        public Aircraft GetAircraftById(int aircraftId)
        {
            var aircraft = new Aircraft()
            {
                AircraftId = 999,
                CallSign = "Air 1",
                TailNumber = "N821SP",
                Status = "Active",
                Make = "Airbus Helicopters",
                Model = "AS-350BA",
                YearManufactured = 1988,
                ModeSCode = "52633060",
                SerialNumber = "2106",
                AircraftType = AircraftType.Rotorcraft,
                EngineType = "Turbo-shaft"
                // aircraft.Engines.Add(new Engine("888", "Turbomeca", "Arriel 1Ser"));
            };
            return aircraft;
        }

    }
}
