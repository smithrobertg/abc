using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Airborne.Commander.AspNetCore.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>())
            {
                if(!context.Missions.Any())
                {
                    context.Missions.AddRange(
                        new Mission { MissionName = "Molly Bish Search", MissionNumber = "17-41923", MissionDate = new DateTimeOffset(new DateTime(2017, 01, 30, 0, 0, 0)), MissionCode = "Lost/Missing Person Search" },
                        new Mission { MissionName = "D-Troop Sweep", MissionNumber = "17-41924", MissionDate = new DateTimeOffset(new DateTime(2017, 01, 30, 0, 0, 0)), MissionCode = "Patrol" },
                        new Mission { MissionName = "H-Troop Sweep", MissionNumber = "17-41925", MissionDate = new DateTimeOffset(new DateTime(2017, 01, 31, 0, 0, 0)), MissionCode = "Patrol" },
                        new Mission { MissionName = "Pilot Training", MissionNumber = "17-41923", MissionDate = new DateTimeOffset(new DateTime(2017, 01, 31, 0, 0, 0)), MissionCode = "AS351BA Flight Training" }
                    );
                }

                if(!context.Aircrafts.Any())
                {
                    context.Aircrafts.AddRange(
                         new Aircraft
                         {
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

                         new Aircraft
                         {
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
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
