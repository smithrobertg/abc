using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class MockRbfRepository : IRbfRepository
    {
        static List<ReadBeforeFlight> _rbfs = new List<ReadBeforeFlight>()
        {
            new ReadBeforeFlight {Id = 1, CreatedDate=new DateTimeOffset(new DateTime(2017, 03, 25, 0, 0, 0)), Airbase="Plymouth", ReportedBy="GAS", Aircraft="N822PP", Occurence="1x", Description="Landing Light", ActionTaken="Action taken.", AircraftGrounded=true, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))},
            new ReadBeforeFlight {Id = 2, CreatedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), Airbase="Plymouth", ReportedBy="KJM", Aircraft="N822PP", Occurence="1x", Description="FAA Alert", ActionTaken="Action taken.", AircraftGrounded=false, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))},
            new ReadBeforeFlight {Id = 3, CreatedDate=new DateTimeOffset(new DateTime(2017, 03, 31, 0, 0, 0)), Airbase="Lawrence", ReportedBy="JPJ", Aircraft="N822PP", Occurence="1x", Description="Engine Light", ActionTaken="Action taken.", AircraftGrounded=false, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))},
            new ReadBeforeFlight {Id = 4, CreatedDate=new DateTimeOffset(new DateTime(2017, 04, 01, 0, 0, 0)), Airbase="Westover", ReportedBy="TBF", Aircraft="N822PP", Occurence="1x", Description="Tail rotor broke off while performing a barrel roll", ActionTaken="Repaired with duct tape.", AircraftGrounded=true, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))}
        };

        public IEnumerable<ReadBeforeFlight> Rbfs => _rbfs;

        public void Add(ReadBeforeFlight rbf)
        {
            _rbfs.Add(rbf);
        }

        public void Delete(ReadBeforeFlight rbf)
        {
            _rbfs.Remove(rbf);
        }

        public ReadBeforeFlight GetRbf(int rbfId)
        {
            return _rbfs.FirstOrDefault(r => r.Id == rbfId);
        }

        public void Update(ReadBeforeFlight rbf)
        {
            var updateRbf = _rbfs.FirstOrDefault(r => r.Id == rbf.Id);
            _rbfs.Remove(updateRbf);

            _rbfs.Add(rbf);

            return;
        }
    }
}
