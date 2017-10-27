using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class AircraftRepository : IAircraftRepository
    {
        private AppDbContext _appDbContext;

        public AircraftRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Aircraft> Aircrafts
        {
            get
            {
                return _appDbContext.Aircrafts;
            }
        }

        public Aircraft GetAircraftById(int aircraftId)
        {
            return _appDbContext.Aircrafts.FirstOrDefault(a => a.AircraftId == aircraftId);
        }

        public void Add(Aircraft aircraft)
        {
            if (aircraft != null)
            {
                _appDbContext.Aircrafts.Add(aircraft);
                _appDbContext.SaveChanges();
            }
        }

        public void Update(Aircraft aircraft)
        {
            if (aircraft != null)
            {
                _appDbContext.Aircrafts.Update(aircraft);
                _appDbContext.SaveChanges();
            }
        }
    }
}
