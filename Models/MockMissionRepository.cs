using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class MockMissionRepository : IMissionRepository
    {
        public IEnumerable<Mission> Missions
        {
            get
            {
                var missions = new List<Mission>()
                {
                    new Mission { MissionId=12345, MissionName="Molly Bish Search", MissionNumber="17-41923", MissionDate=new DateTimeOffset(new DateTime(2017, 01, 30, 0, 0, 0)),MissionCode="Lost/Missing Person Search"},
                    new Mission { MissionId=12346, MissionName="D-Troop Sweep", MissionNumber="17-41924", MissionDate=new DateTimeOffset(new DateTime(2017, 01, 30, 0, 0, 0)),MissionCode="Patrol"},
                    new Mission { MissionId=12347, MissionName="H-Troop Sweep", MissionNumber="17-41925", MissionDate=new DateTimeOffset(new DateTime(2017, 01, 31, 0, 0, 0)),MissionCode="Patrol"},
                    new Mission { MissionId=12348, MissionName="Pilot Training", MissionNumber="17-41923", MissionDate=new DateTimeOffset(new DateTime(2017, 01, 31, 0, 0, 0)),MissionCode="AS351BA Flight Training"}
                };
                return missions;
            }
        }

        public Mission GetMissionById(int missionId)
            => new Mission { MissionId = missionId, MissionName = @"Mission ID = {missionId}", MissionNumber = "17-99999", MissionDate = new DateTimeOffset(new DateTime(2017, 01, 1, 0, 0, 0)), MissionCode = "Patrol" };

        public void AddMission(Mission mission)
        {
            return;
        }

        public void Update(Mission mission)
        {
            return;
        }

        public void Delete(Mission mission)
        {
            return;
        }
    }
}
