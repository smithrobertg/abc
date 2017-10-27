using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class Aircraft
    {
        public int AircraftId { get; set; }

        [Display(Name = "Call Sign")]
        [Required(ErrorMessage = "Please enter Call Sign")]
        public string CallSign { get; set; }

        [Display(Name = "Tail Number")]
        [Required(ErrorMessage = "Please enter Tail Number")]
        public string TailNumber { get; set; }

        public string Status { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [Display(Name = "Year Manufactured")]
        public int YearManufactured { get; set; }

        public string ModeSCode { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name = "Aircraft Type")]
        public AircraftType AircraftType { get; set; }

        [Display(Name = "Engine Type")]
        public string EngineType { get; set; }

        [Display(Name = "Aircraft Total Time")]
        public double AircraftTotalTime { get; set; }

        [Display(Name = "Maintenance Hobbs Time")]
        public double MaintenanceHobbs { get; set; }

        [Display(Name = "Flight Hobbs Time")]
        public double FlightHobbs { get; set; }
        public int Landings { get; set; }

        [Display(Name = "Tourque Events")]
        public int TourqueEvents { get; set; }

        [Display(Name = "Tourque Events RIN")]
        public int TourqueEventsRIN { get; set; }

        [Display(Name = "FAA Registration Expiration")]
        public DateTimeOffset FaaRegistrationExpiration { get; set; }

        public IList<Engine> Engines { get; set; }
    }

    public enum AircraftType
    {
        Rotorcraft,
        FixedWing
    }

}
