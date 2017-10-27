using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Airborne.Commander.AspNetCore.Models
{
    public class Discrepancy : IAlert
    {
        public int Id { get; set; }

        [DisplayName("Discrepancy Date")]
        public DateTimeOffset CreatedDate { get; set; }
        public string Aircraft { get; set; }
        public string Airbase { get; set; }
        public string Occurence { get; set; }
        [DisplayName("Reported By")]
        public string ReportedBy { get; set; }
        public string Description { get; set; }
        [DisplayName("Aircraft Grounded")]
        public bool AircraftGrounded { get; set; }
        [DisplayName("Grounded Date")]
        public DateTimeOffset AircraftGroundedDate { get; set; }
        [DisplayName("In-Service Date")]
        public DateTimeOffset InServiceDate { get; set; }
        [DisplayName("Action Taken")]
        public string ActionTaken { get; set; }

        //TODO: This should probably be an extension method in a static utility class
        public string ShortDescription(int length = 20)
        {
            int descriptionLength = Description.Length;

            if (descriptionLength <= length)
            {
                return Description;
            }
            else
            {
                return Description.Substring(0, length) + "...";
            }
        }
    }
}
