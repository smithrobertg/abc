using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class MockDiscrepancyRepository : IDiscrepancyRepository
    {
        static List<Discrepancy> _discrepancies = new List<Discrepancy>()
        {
            new Discrepancy {Id = 1, CreatedDate=new DateTimeOffset(new DateTime(2017, 02, 25, 0, 0, 0)), Airbase="Plymouth", ReportedBy="GAS", Aircraft="N822PP", Occurence="1x", Description="Landing Light", ActionTaken="Action taken.", AircraftGrounded=true, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))},
            new Discrepancy {Id = 2, CreatedDate=new DateTimeOffset(new DateTime(2017, 03, 21, 0, 0, 0)), Airbase="Plymouth", ReportedBy="KJM", Aircraft="N822PP", Occurence="1x", Description="Small chip in blade", ActionTaken="Action taken.", AircraftGrounded=false, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))},
            new Discrepancy {Id = 3, CreatedDate=new DateTimeOffset(new DateTime(2017, 04, 7, 0, 0, 0)), Airbase="Lawrence", ReportedBy="JPJ", Aircraft="N822PP", Occurence="1x", Description="Engine Light", ActionTaken="Action taken.", AircraftGrounded=false, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))},
            new Discrepancy {Id = 4, CreatedDate=new DateTimeOffset(new DateTime(2017, 04, 15, 0, 0, 0)), Airbase="Westover", ReportedBy="TBF", Aircraft="N822PP", Occurence="1x", Description="Tail rotor broke off while performing a barrel roll", ActionTaken="Repaired with duct tape.", AircraftGrounded=true, AircraftGroundedDate=new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0)), InServiceDate= new DateTimeOffset(new DateTime(2017, 03, 30, 0, 0, 0))}
        };

        public IEnumerable<Discrepancy> Discrepancies => _discrepancies;

        public void Add(Discrepancy discrepancy)
        {
            _discrepancies.Add(discrepancy);
        }

        public void Delete(Discrepancy discrepancy)
        {
            _discrepancies.Remove(discrepancy);
        }

        public Discrepancy GetDiscrepancy(int Id)
        {
            return _discrepancies.FirstOrDefault(d => d.Id == Id);
        }

        public void Update(Discrepancy discrepancy)
        {
            var updateDiscrepancy = _discrepancies.FirstOrDefault(d => d.Id == discrepancy.Id);
            _discrepancies.Remove(updateDiscrepancy);

            _discrepancies.Add(discrepancy);

            return;
        }
    }
}
