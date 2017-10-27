using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airborne.Commander.AspNetCore.Models
{
    public class StaticFrat : IFratForm
    {
        public int Id { get; set; }

        [DisplayName("Illness/Physical Condition")]
        public int Pilot_IllnessPhysicalCondition { get; set; }
        [DisplayName("Medication")]
        public int Pilot_Medication { get; set; }
        [DisplayName("Fatigue")]
        public int Pilot_Fatigue { get; set; }
        [DisplayName("Total Flight Time")]
        public int Pilot_TotalFlightTime { get; set; }
        [DisplayName("Flight Time in Make/Model")]
        public int Pilot_FlightTimeInMakeModel { get; set; }
        [DisplayName("Last Flight in Make/Model")]
        public int Pilot_LastFlightInMakeModel { get; set; }
        [DisplayName("Currency Training")]
        public int Pilot_CurrencyTraining { get; set; }
        [DisplayName("IMC Prep")]
        public int Pilot_ImcPrep { get; set; }

        public int TfoCoPilot_IllnessPhysicalCondition { get; set; }
        public int TfoCoPilot_Medication { get; set; }
        public int TfoCoPilot_Fatigue { get; set; }
        public int TfoCoPilot_TotalFlightTime { get; set; }
        public int TfoCoPilot_FlightCrew { get; set; }
        public int TfoCoPilot_ImcPrep { get; set; }

        public int Aircraft_RecentMaintenance { get; set; }
        public int Aircraft_KnownDiscrepancies { get; set; }
        public int Aircraft_Performance { get; set; }

        public bool ThirdCrewMember { get; set; }   // Subtract 2
        public bool SoloFlight { get; set; }        // Add 2

        public virtual Frat Frat { get; set; }

        public int Total { get =>
                Pilot_IllnessPhysicalCondition
                + Pilot_Medication
                + Pilot_Fatigue
                + Pilot_TotalFlightTime
                + Pilot_FlightTimeInMakeModel
                + Pilot_LastFlightInMakeModel
                + Pilot_CurrencyTraining
                + Pilot_ImcPrep
                + TfoCoPilot_IllnessPhysicalCondition
                + TfoCoPilot_Medication
                + TfoCoPilot_Fatigue
                + TfoCoPilot_TotalFlightTime
                + TfoCoPilot_FlightCrew
                + TfoCoPilot_ImcPrep
                + Aircraft_RecentMaintenance
                + Aircraft_KnownDiscrepancies
                + Aircraft_Performance
                + (SoloFlight ? 2 : 0)
                - (ThirdCrewMember ? 2 : 0);
                }
    }
}
