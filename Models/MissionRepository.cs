using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class MissionRepository : IMissionRepository
    {
        private readonly AppDbContext _appDbContext;

        public MissionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Mission> Missions
        {
            get
            {
                return _appDbContext.Missions;
            }
        }

        public Mission GetMissionById(int missionId)
        {
            return _appDbContext.Missions.FirstOrDefault(p => p.MissionId == missionId);
        }

        public void AddMission(Mission mission)
        {
            if (mission != null)
            {
                _appDbContext.Missions.Add(mission);
                _appDbContext.SaveChanges();
            }
        }

        public void Update(Mission mission)
        {
            if (mission != null)
            {
                _appDbContext.Missions.Update(mission);
                _appDbContext.SaveChanges();
            }
        }

        public void Delete(Mission mission)
        {
            if (mission != null)
            {
                _appDbContext.Missions.Remove(mission);  //TODO: Set the IsDeleted flag instead of deleting data row
                _appDbContext.SaveChanges();
            }
        }
    }
}
