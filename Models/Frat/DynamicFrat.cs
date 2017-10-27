using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Airborne.Commander.AspNetCore.Models
{
    public class DynamicFrat : IFratForm
    {
        public int Id { get; set; }

        [DisplayName("Hours on Duty")]
        public int Aircrew_HoursOnDuty { get; set; }
        [DisplayName("Time of Day")]
        public int Aircrew_TimeOfDay { get; set; }
        [DisplayName("Flight Hours within 24hrs (8 hours MAX)")]
        public int Aircrew_FlightHoursWithin24Hours { get; set; }

        [DisplayName("Ceiling")]
        public int Environment_Ceiling { get; set; }
        [DisplayName("Visibility")]
        public int Environment_Visibility { get; set; }
        [DisplayName("Winds")]
        public int Environment_Winds { get; set; }
        [DisplayName("Convective Activity")]
        public int Environment_ConvectiveActivity { get; set; }
        [DisplayName("Forecast Conditions")]
        public int Environment_ForecastConditions { get; set; }
        [DisplayName("Terrain")]
        public int Environment_Terrain { get; set; }
        [DisplayName("Fog")]
        public int Environment_Fog { get; set; }
        [DisplayName("Icing")]
        public int Environment_Icing { get; set; }

        [DisplayName("Mission Type")]
        public int Mission_Type { get; set; }
        [DisplayName("Day/Night NVG")]
        public int Mission_DayNightNvg { get; set; }
        [DisplayName("External Pressure")]
        public int Mission_ExternalPressure { get; set; }

        public int Total => Aircrew_HoursOnDuty
                            + Aircrew_TimeOfDay
                            + Aircrew_FlightHoursWithin24Hours
                            + Environment_Ceiling
                            + Environment_Visibility
                            + Environment_Winds
                            + Environment_ConvectiveActivity
                            + Environment_ForecastConditions
                            + Environment_Terrain
                            + Environment_Fog
                            + Environment_Icing
                            + Mission_Type
                            + Mission_DayNightNvg
                            + Mission_ExternalPressure;
    }
}
