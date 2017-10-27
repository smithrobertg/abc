using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public interface IMissionRepository
    {
        IEnumerable<Mission> Missions { get; }
        Mission GetMissionById(int missionId);
        void AddMission(Mission mission);
        void Update(Mission mission);
        void Delete(Mission mission);
    }
}
