using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class Mission
    {
        public int MissionId { get; set; }

        [Display(Name = "Mission Number")]
        [Required(ErrorMessage = "Please enter Mission Number")]
        public string MissionNumber { get; set; }

        [Display(Name = "Mission Name")]
        [Required(ErrorMessage = "Please enter Mission Name")]
        public string MissionName { get; set; }

        [Display(Name = "Mission Date")]
        [Required(ErrorMessage = "Please enter Mission Date")]
        public DateTimeOffset MissionDate { get; set; }

        [Display(Name = "Request Date")]
        public DateTimeOffset RequestDate { get; set; }

        [Display(Name = "AirBase")]
        public string AirBase { get; set; }

        [Display(Name = "Cancel Codes")]
        public List<CancelCode> CancelCodes { get; set; }

        [Display(Name = "Launch Time")]
        public DateTime LauchTime { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Mission Number")]
        public string AuthorizedBy { get; set; }

        public bool MidShiftCallout { get; set; }
        public bool OvertimeMission { get; set; }
        public bool BostonPdPatrol { get; set; }
        public string TroopJurisdiction { get; set; }
        public string CityTown { get; set; }

        [Display(Name = "Mission Code")]
        public string MissionCode { get; set; }

        public string RequestingAgency { get; set; }
        public bool Msp { get; set; }
        public string PickupLocation { get; set; }
        public string FlightConfirmationInfo { get; set; }
        public string Description { get; set; }
        public string Gist { get; set; }

        public class CancelCode
        {
            public int CancelCodeId { get; set; }
            public string Code { get; set; }
        }
    }
}
